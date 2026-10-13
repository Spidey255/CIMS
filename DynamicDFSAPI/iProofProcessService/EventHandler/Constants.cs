#region Header
// --------------------------------------------------------------------------------------
// <copyright file="Constants.cs" company="Cognitive Platform Solutions Pvt Ltd.">
// Reproduction or transmission, in whole or in part, in any form or 
// by any means including electronic or mechanical or otherwise, is 
// prohibited without written permission from Cognitive Platform Solutions Pvt Ltd.
// </copyright>
// ---------------------------------------------------------------------------------------
#endregion


namespace CPS.Proof.DFSExtension
{
    /// <summary>
    /// Represents the class that contains all the constant values used 
    /// by the ProcessGateway.
    /// </summary>
    internal class Constants
    {
        /// <summary>
        /// A <see cref="string"/> value that holds the UnlockKey string.
        /// </summary>
        public const string UnlockKey = "UnlockKey";

        /// <summary>
        /// A <see cref="string"/> value that holds the 
        /// configuration key name SMTPMailHost.
        /// </summary>
        public const string SmtpMailHost = "SMTPMailHost";

        /// <summary>
        /// A <see cref="string"/> value that holds the 
        /// configuration key name SMTPUserName.
        /// </summary>
        public const string SmtpUserName = "SMTPUserName";

        /// <summary>
        /// A <see cref="string"/> value that holds the 
        /// configuration key name SMTPPassword.
        /// </summary>
        public const string SmtpPassword = "SMTPPassword";

        /// <summary>
        /// A <see cref="string"/> value that holds the 
        /// configuration key name SMTPMailPort.
        /// </summary>
        public const string SmtpMailPort = "SMTPMailPort";

        /// <summary>
        /// A <see cref="string"/> value that holds 
        /// the configuration key Name EmailBounceAddress.
        /// </summary>
        public const string EmailBounceAddress = "EmailBounceAddress";

        /// <summary>
        /// A <see cref="string"/> value that holds json content type.
        /// </summary>
        public const string JsonContentType = "application/json; charset=UTF-8";

        /// <summary>
        /// A <see cref="string"/> value that holds xml content type.
        /// </summary>
        public const string XmlContentType = "text/xml; charset=utf-8";

        /// <summary>
        /// A <see cref="string"/> value that holds form url encoded content type.
        /// </summary>
        public const string FormUrlEncodedContentType = "application/x-www-url-formencoded";

        /// <summary>
        /// A <see cref="string"/> value that holds form data.
        /// </summary>
        public const string FormDataContentType = "multipart/form-data";

        /// <summary>
        /// A <see cref="string"/> value that holds text content type.
        /// </summary>
        public const string TextContentType = "text/plain; charset=utf-8";
        

    }
}
