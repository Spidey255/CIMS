
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPS.Proof.DFSExtension
{
    public  class HttpRequest
    {
        /// <summary>
        /// Gets or Sets a <see cref="string"/>that contains the 
        /// RequestPath
        /// </summary>
        public string RequestPath { get; set; }

        /// <summary>
        /// Gets or Sets a <see cref="string"/>that contains the 
        /// Domain
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Gets or Sets a <see cref="string"/>that contains the 
        /// SoapAction
        /// </summary>
        public string SoapAction { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="System.Int16"/> that contains the 
        /// ContentType id
        /// (1-SOAP,2-XML,3-JSON)
        /// </summary>
        public ContentType ContentType { get; set; }

        /// <summary>
        /// Gets or Sets a <see cref="List{T}"/>that contains the 
        /// RequestFields
        /// </summary>
        public List<RequestFieldElements> RequestFields { get; set; }

        /// <summary>
        /// Gets or Sets a <see cref="string"/>that contains the 
        /// Template
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// Gets or Sets a <see cref="System.Int16"/>that contains the 
        /// Port
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Gets or Sets a <see cref="string"/>that contains the 
        /// CharSet
        /// </summary>
        public string CharSet { get; set; }

        /// <summary>
        /// Gets or Sets a <see cref="ConnectionTypes"/>that contains the 
        /// ConnectionType
        /// </summary>
        public ConnectionTypes ConnectionType { get; set; }

        /// <summary>
        /// Gets or sets Request IdleTimeOut in milliseconds
        /// default 30000 ms
        /// </summary>
        public int IdleTimeOutMs { get; set; }

        /// <summary>
        /// Gets or Sets a <see cref="RequestType"/>that contains the 
        /// RequestType
        /// </summary>
        public RequestType RequestType { get; set; }

        /// <summary>
        /// Gets or Sets a <see cref="string"/>that contains the 
        /// RequestType
        /// </summary>
        public string RequestData { get; set; }

        /// <summary>
        /// Gets or Sets a <see cref="string"/>that contains the 
        /// UserName
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///  Gets or Sets a <see cref="string"/>that contains the 
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="System.Boolean"/> 
        /// that contains the RequireAuthentication state
        /// </summary>
        public bool RequireAuthentication { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="System.Boolean"/> 
        /// that contains the HasRqstBdy state
        /// </summary>
        public bool HasRequestBody { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="System.Boolean"/> 
        /// AutoReconnect state
        /// </summary>
        public bool AutoReconnect { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="System.Boolean"/> 
        /// TransportLayeredService state
        /// </summary>
        public bool TransportLayeredService { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="string"/>
        /// Status Codes that need to be handled.
        /// </summary>
        public string SuccessCodes { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="string"/>
        /// Error Codes that need to be handled.
        /// </summary>
        public string ErrorCodes { get; set; }

        /// <summary>
        /// Gets or Sets a <see cref="int"/>
        /// that holds no of retries.
        /// </summary>
        public int Retries { get; set; }

        /// <summary>
        /// Gets or Sets a <see cref="int"/>
        /// that holds no of retry interval.
        /// </summary>
        public double RetryInterval { get; set; }

        /// <summary>
        /// Gets or Sets a <see cref="int"/>
        /// that holds IsAsync.
        /// </summary>
        public bool IsAsync { get; set; }      

    }
}
