
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using log4net;
using ck = Chilkat;
using System.Linq;
using Chilkat;
using SRA.Proof.Middleware;

namespace CPS.Proof.DFSExtension
{
    public class RestExecutor : IRestExecutor
    {
       
        #region Private Members

        /// <summary>
        /// A <see cref="ILog"/> instance used for application logging.
        /// </summary>
        private readonly ILog _log;

        /// <summary>
        /// A <see cref="string"/> that holds chilkat key
        /// </summary>
        private string _unlockKey = null;

        /// <summary>
        /// A <see cref="bool"/> that holds unlocked status.
        /// </summary>
        private bool _isUnlocked = false;


        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new instance of 
        /// <see cref="RestExecutor"/>.
        /// </summary>        
        public RestExecutor()
        {

            _log = LogManager.GetLogger(this.GetType());

            _unlockKey = AppParams.GetAppSettings(Constants.UnlockKey);

            //Starting in v9.5.0.49, all Chilkat classes can be unlocked
            //  at once at the beginning of a program
            //  by calling UnlockBundle.It requires a Bundle unlock code.

            var chilkatGlob = new ck.Global();

            _isUnlocked = chilkatGlob.UnlockBundle(_unlockKey);

        }

        #endregion


        public Status ExecuteRest(HttpRequest request, out string response)
        {
            IChilkatInstantiator chilkatInstantiator = null;

            ck.Rest rest = null;

            response = null;

            try
            {
                _log.Debug("Entering RestExecution");


                //Checking whether Chillkat bundle is unlocked.
                if (!_isUnlocked)
                {
                    _log.Debug("Chilkat Key is not valid");

                    return Status.Failure;
                }

                bool success = false;
                bool isFormUrlEncoded = false;
                bool isMultipart = false;
                bool isForm = false;

                foreach (var data in request.RequestFields)
                {
                    if (data.ParamType == 8)
                    {
                        isMultipart = true;

                        _log.Debug("Multipart Request");

                        break;
                    }
                }

                //if (isMultipart)
                //    return SendMultiPartRequest(request, out response);

                chilkatInstantiator = new ChilkatWrapper();

                rest = chilkatInstantiator.GetChilkatInstance();

                //  Use Basic Authentication.
                if (request.RequireAuthentication)
                {
                    ck.Crypt2 crypt = new ck.Crypt2();

                    ck.SecureString ssLogin = new ck.SecureString();

                    ck.SecureString ssPassword = new ck.SecureString();

                    // Decrypt to the secure string.
                    // (the strings will still held in memory encrypted, but are now encrypted using// a randomly generated session key.)
                    crypt.DecryptSecureENC(request.UserName, ssLogin);
                    crypt.DecryptSecureENC(request.Password, ssPassword);

                    success = rest.SetAuthBasicSecure(ssLogin,
                        ssPassword);

                    if (success != true)
                    {
                        _log.DebugFormat("Error in SetAuthBasic {0}",
                            rest.LastErrorText);

                        return Status.Failure;
                    }
                }


                #region Add QueryParam/HeaderParam/BodyParam

                //var value = String.Empty;
                Dictionary<string, string> docData = null;
                int part = 0;
                foreach (var data in request.RequestFields)
                {
                    var value = String.Empty;
                    if (!string.IsNullOrEmpty(data.Path))
                    {
                        _log.DebugFormat("Path :{0}", data.Path);
                        continue;
                    }

                    if (IsDictionary(data.Value))
                    {
                        docData = null;

                        var docDataByteString = JsonConvert.SerializeObject(data.Value); //string to be converted to dictionary

                        if (!string.IsNullOrEmpty(docDataByteString))
                            docData = JsonConvert.DeserializeObject<Dictionary<string, string>>(docDataByteString);

                        if (docData != null && docData.Keys != null && docData.Keys.Count > 0)
                        {
                            _log.DebugFormat("docData : {0}", docData.Keys.FirstOrDefault());

                            if (data.FieldName.ToLower() == "docid")
                                value = docData.Keys.FirstOrDefault().Split('!')[0];
                            else
                            {
                                value = docData.Keys.FirstOrDefault().Split('!')[1];

                            }
                        }
                    }
                    else
                    {

                        if (data.Value != null)
                            value = Convert.ToString(data.Value);
                    }



                    if (string.IsNullOrWhiteSpace(value))
                        value = data.DefaultValue;
                    else
                        value = value.Trim();


                    if (data.Value != null)
                    {
                        if (data.Value.ToString() == "0")
                            value = data.DefaultValue;
                    }


                    _log.DebugFormat("Value : {0}", value);

                    switch (data.ParamType)
                    {
                        case 1:
                            {
                                success = rest.AddQueryParam(data.FieldName, value);
                                _log.DebugFormat("Query : FieldName :{0}, Value:{1}", data.FieldName, value);
                                break;
                            }
                        case 2:
                            if (request.Template != null)
                            {
                                success = true;

                                if (docData != null && docData.Keys.Count > 0)
                                {
                                    if (data.FieldName.ToLower().EndsWith("_key"))
                                        request.Template = request.Template.Replace
                                        (string.Format("#{0}", data.FieldName),
                                         docData.Keys.FirstOrDefault());

                                    if (data.FieldName.ToLower().EndsWith("_value"))
                                        request.Template = request.Template.Replace
                                        (string.Format("#{0}", data.FieldName),
                                        docData.Values.FirstOrDefault());
                                }
                                else
                                {
                                    request.Template = request.Template.Replace
                                        (string.Format("#{0}", data.FieldName),
                                        value);

                                    _log.DebugFormat("Body : FieldName :{0}, Value:{1}", data.FieldName, value);
                                }
                            }
                            break;

                        case 3:
                            {
                                success = rest.AddHeader(data.FieldName, value);
                                _log.DebugFormat("Header : FieldName :{0}, Value:{1}", data.FieldName, value);
                                break;
                            }
                        case 4:
                            {
                                success = rest.AddPathParam(data.FieldName, value);
                                _log.DebugFormat("Path : FieldName :{0}, Value:{1}", data.FieldName, value);
                                break;
                            }
                        case 5:
                            {
                                _log.DebugFormat("FormData : FieldName :{0}, Value:{1}", data.FieldName, value);

                                if (part == 0)
                                {
                                    isForm = true;
                                    success = rest.AddHeader("Content-Type",
                                        Constants.FormDataContentType);

                                    if (success != true)
                                    {
                                        _log.DebugFormat("Error in Adding Content-Type {0}",
                                            rest.LastErrorText);

                                        return Status.Failure;
                                    }
                                }
                                //success = rest.AddQueryParam(data.FieldName, value);
                                rest.PartSelector = (++part).ToString();
                                success = rest.AddHeader("Content-Disposition", "form-data; name=" + "\"" + data.FieldName + "\"");
                                if (success != true)
                                {
                                    _log.DebugFormat("Error in Adding Content-Type {0}",
                                        rest.LastErrorText);

                                    return Status.Failure;
                                }
                                success = rest.SetMultipartBodyString(value);


                                if (success != true)
                                {
                                    _log.DebugFormat("Error in Adding Content-Type {0}",
                                        rest.LastErrorText);

                                    return Status.Failure;
                                }

                                break;
                            }
                        case 6:
                            {
                                isFormUrlEncoded = true;
                                success = rest.AddQueryParam(data.FieldName, value);
                                _log.DebugFormat("FormUrlEncoded : FieldName :{0}, Value:{1}", data.FieldName, value);
                                break;
                            }
                        case 7:
                            {
                                success = true;
                                ck.StringBuilder sbAuthHeaderVal = new ck.StringBuilder();
                                sbAuthHeaderVal.Append("Bearer ");
                                sbAuthHeaderVal.Append(value);
                                rest.Authorization = sbAuthHeaderVal.GetAsString();
                                _log.DebugFormat("Bearer :{0}", sbAuthHeaderVal.GetAsString());
                                break;
                            }
                        case 9:
                            {
                                _log.DebugFormat("Json : FieldName :{0}, Value:{1}", data.FieldName, value);
                                request.Template = value;
                                success = true;
                                break;
                            }
                        default:
                            break;
                    }

                    if (success != true)
                    {
                        _log.Error(rest.LastErrorText);

                        return Status.Failure;
                    }
                }

                #endregion

                if (request.IdleTimeOutMs > 0)
                    rest.IdleTimeoutMs = request.IdleTimeOutMs;

                Status status = SendRestRequest(ref rest, request,
                    isFormUrlEncoded, isForm, out response);

                _log.DebugFormat(@"Service request info - RequestType:{0}, RequestPath:{1}",
                            request.RequestType, request.RequestPath);

                return status;
            }
            catch (Exception ex)
            {
                _log.DebugFormat("Error in Rest Execution", ex);

                return Status.Failure;
            }
            finally
            {
                if (rest != null)
                    chilkatInstantiator.Disconnect(rest);

                if (chilkatInstantiator != null)
                    ObjectManager.Release<IChilkatInstantiator>(chilkatInstantiator);

                _log.Debug("Exiting RestExecution");
            }
        }

        /// <summary>
        /// Represents the method that sends rest request.
        /// </summary>
        /// <param name="rest">
        /// A <see cref="Rest"/> that 
        /// holds rest reference
        /// </param>
        /// <param name="request">
        /// A <see cref="Helpers.HttpRequest"/> that holds 
        /// </param>
        /// <param name="isFormUrlEncoded"></param>
        /// <param name="response"></param>
        /// <returns></returns>
        private Status SendRestRequest(ref ck.Rest rest,
            HttpRequest request, bool isFormUrlEncoded,
                bool isForm, out string response)
        {
            response = null;

            bool success = false;

            short count = 0;

            rest.ConnectTimeoutMs = rest.IdleTimeoutMs;

            //  Connect to the REST server.  
            success = rest.Connect(request.Domain, request.Port,
                request.TransportLayeredService, request.AutoReconnect);

            if (!success)
            {
                _log.DebugFormat("Error in Connecting {0} {1} {2}",
                    request.Domain, request.Port, rest.LastErrorText);

                return Status.Failure;
            }
            bool statusRequired = false;
            while (count <= request.Retries)
            {

                // Send the request
                if (request.HasRequestBody)
                {
                    var contentType = Constants.TextContentType;

                    if (request.ContentType == ContentType.JSON)
                        contentType = Constants.JsonContentType;

                    if (request.ContentType == ContentType.XML)
                        contentType = Constants.XmlContentType;

                    success = rest.AddHeader("Content-Type", contentType);

                    if (success != true)
                    {
                        _log.DebugFormat("Error in Adding Content-Type {0}",
                            rest.LastErrorText);

                        return Status.Failure;
                    }

                    if (request.ContentType == ContentType.SOAP)
                    {
                        contentType = Constants.XmlContentType;

                        success = rest.AddHeader("Content-Type", contentType);

                        success = rest.AddHeader("SOAPAction", request.SoapAction);

                        if (success != true)
                        {
                            _log.DebugFormat("Error in Adding SOAPAction {0}",
                            rest.LastErrorText);

                            return Status.Failure;
                        }
                    }

                    _log.DebugFormat(@"Service request info - RequestType:{0},
                            RequestPath:{1}, Template:{2}, ContentType:{3}",
                                request.RequestType.ToString().ToUpper(),
                                    request.RequestPath, request.Template,
                                        request.ContentType);

                    _log.DebugFormat("Request Json : {0}", request.Template);

                    if (request.IsAsync)
                    {
                        response = rest.FullRequestStringAsync(
                            request.RequestType.ToString().ToUpper(),//Httpverb
                            request.RequestPath, //URl
                            request.Template).Status;//BodyText
                    }
                    else
                    {
                        response = rest.FullRequestString(
                            request.RequestType.ToString().ToUpper(),//Httpverb
                            request.RequestPath, //URl
                            request.Template);//BodyText   
                    }
                }
                else if (isFormUrlEncoded)
                {
                    success = rest.AddHeader("Content-Type",
                        Constants.FormUrlEncodedContentType);

                    if (success != true)
                    {
                        _log.DebugFormat("Error in Adding Content-Type {0}",
                            rest.LastErrorText);

                        return Status.Failure;
                    }

                    _log.DebugFormat(@"Service request info - RequestType:{0},
                            RequestPath:{1}, ContentType:{2}",
                                request.RequestType.ToString().ToUpper(),
                                     request.RequestPath,
                                        Constants.FormUrlEncodedContentType);

                    if (request.IsAsync)
                    {
                        response = rest.FullRequestFormUrlEncodedAsync
                           (request.RequestType.ToString().ToUpper(),//Httpverb
                               request.RequestPath).Status;//URL
                    }
                    else
                    {
                        response = rest.FullRequestFormUrlEncoded
                            (request.RequestType.ToString().ToUpper(),//Httpverb
                                request.RequestPath);//URL
                    }
                }
                else if (isForm)
                {
                    _log.DebugFormat(@"Service request info - RequestType:{0},
                            RequestPath:{1}, ContentType:{2}",
                                request.RequestType.ToString().ToUpper(),
                                     request.RequestPath,
                                        Constants.FormDataContentType);

                    if (request.IsAsync)
                    {
                        response = rest.FullRequestMultipartAsync(
                        request.RequestType.ToString().ToUpper(),//Httpverb
                        request.RequestPath).Status;//URL 
                    }
                    else
                    {
                        response = rest.FullRequestMultipart(
                        request.RequestType.ToString().ToUpper(),//Httpverb
                        request.RequestPath);//URL 
                    }
                }
                else
                {
                    if (request.IsAsync)
                    {
                        response = rest.FullRequestNoBodyAsync(
                        request.RequestType.ToString().ToUpper(),//Httpverb
                        request.RequestPath).Status;//URL 
                    }
                    else
                    {
                        response = rest.FullRequestNoBody(
                        request.RequestType.ToString().ToUpper(),//Httpverb
                        request.RequestPath);//URL 
                    }

                    _log.DebugFormat(@"Service request info - RequestType:{0}, RequestPath:{1}",
                          request.RequestType, request.RequestPath);
                }

                if (!string.IsNullOrEmpty(request.SuccessCodes))
                {
                    _log.DebugFormat("Success Codes:{0}", request.SuccessCodes);

                    if (request.SuccessCodes.Contains(rest.ResponseStatusCode.ToString()))
                        statusRequired = true;
                }

                if ((rest.LastMethodSuccess != true || rest.ResponseStatusCode != 200) && !statusRequired)
                {
                    _log.DebugFormat(@"Service request is unsuccessfull
                         for the URL - Domain:{0}, RequestPath:{1}, RequestType:{2}",
                            request.Domain, request.RequestPath, request.RequestType.ToString());

                    _log.DebugFormat("Service Error : {0}", rest.LastErrorText);


                    count++;                  

                    int time = Convert.ToInt32(request.RetryInterval) * 1000;

                    System.Threading.Thread.Sleep(time);
                }
                else
                {                  

                    break;
                }
            }

            _log.DebugFormat(@"Status Code:{0}, Status Text:{1}",
                rest.ResponseStatusCode, rest.ResponseStatusText);

            //log

            _log.DebugFormat("Response String:{0}", response);

            bool errorRequired = false;

            if (!string.IsNullOrEmpty(request.ErrorCodes))
            {
                _log.DebugFormat("Error Codes:{0}", request.ErrorCodes);

                if (request.ErrorCodes.Contains(response))
                    errorRequired = true;
            }

            if (!statusRequired && !errorRequired)
            {
                if (rest.ResponseStatusCode != 200)
                {
                    _log.Debug("Request Sent UnSuccessfully");

                    return Status.Failure;
                }
            }

            return Status.Success;

        }


        /// <summary>
        /// Represents the method that checks
        /// whether given object is dictionary or not
        /// </summary>
        /// <param name="obj">
        /// A <see cref="object"/> that holds
        /// object
        /// </param>
        /// <returns></returns>
        private bool IsDictionary(object obj)
        {
            if (obj == null) return false;

            return obj is Dictionary<string, string>;
        }

          }
}
