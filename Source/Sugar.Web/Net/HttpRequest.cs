﻿using System;
using System.Collections.Specialized;
using System.Net;
using System.Net.Security;
using System.Text;

namespace Sugar.Net
{
    /// <summary>
    /// Represents a request to download a file from the internet
    /// </summary>
    public class HttpRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpRequest"/> class.
        /// </summary>
        public HttpRequest()
        {
            Retries = 3;
            Timeout = 30000;
            Verb = HttpVerb.Get;
            Headers = new NameValueCollection();
            Cookies = new CookieContainer();
            Encoding = null;
            AllowAutoRedirect = true;
            MaximumRedirects = 10;
            Host = null;
            SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;

            // No certificate validation by default
            ServerCertificateValidationCallback = delegate { return true; };
        }

        /// <summary>
        /// Gets or sets the verb.
        /// </summary>
        /// <value>
        /// The verb.
        /// </value>
        public HttpVerb Verb { get; set; }

        /// <summary>
        /// Gets or sets the URL to download.
        /// </summary>
        /// <value>The URL.</value>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets the user agent.
        /// </summary>
        /// <value>The user agent.</value>
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets the content type.
        /// </summary>
        /// <value>
        /// The content tent.
        /// </value>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the timeout.
        /// </summary>
        /// <value>
        /// The timeout.
        /// </value>
        public int Timeout { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use basic authentication.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [use basic authentication]; otherwise, <c>false</c>.
        /// </value>
        public bool UseBasicAuthentication { get; set; }

        /// <summary>
        /// Gets a value indicating whether to use authentication for this request
        /// </summary>
        /// <value><c>true</c> if [use authentication]; otherwise, <c>false</c>.</value>
        public bool UseAuthentication => !(string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(Password));

        /// <summary>
        /// Gets or sets the proxy to use for this request.
        /// </summary>
        /// <value>
        /// The proxy object.
        /// </value>
        public HttpProxy Proxy { get; set; }

        /// <summary>
        /// Gets or sets the number of retries if the download fails.
        /// </summary>
        /// <value>
        /// The retries.
        /// </value>
        public int Retries { get; set; }

        /// <summary>
        /// Gets or sets the headers.
        /// </summary>
        /// <value>
        /// The headers.
        /// </value>
        public NameValueCollection Headers { get; private set; }

        /// <summary>
        /// Gets the cookies.
        /// </summary>
        public CookieContainer Cookies { get; set; }

        /// <summary>
        /// Gets or sets the referer.
        /// </summary>
        /// <value>
        /// The referer.
        /// </value>
        public string Referer { get; set; }

        /// <summary>
        /// Gets or sets the host.
        /// </summary>
        /// <value>
        /// The host.
        /// </value>
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets the accept.
        /// </summary>
        /// <value>
        /// The accept.
        /// </value>
        public string Accept { get; set; }

        /// <summary>
        /// Gets or sets the encoding.
        /// </summary>
        /// <value>
        /// The encoding.
        /// </value>
        public Encoding Encoding { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this request allows auto redirects.
        /// </summary>
        /// <value>
        ///   <c>true</c> if to allow auto redirect; otherwise, <c>false</c>.
        /// </value>
        public bool AllowAutoRedirect { get; set; }

        /// <summary>
        /// Gets or sets the current redirects.
        /// </summary>
        /// <value>
        /// The current redirects.
        /// </value>
        public int CurrentRedirects { get; set; }

        /// <summary>
        /// Gets or sets the maximum redirects.
        /// </summary>
        /// <value>
        /// The maximum redirects.
        /// </value>
        public int MaximumRedirects { get; set; }

        /// <summary>
        /// Gets or sets the type of the security protocol.
        /// </summary>
        /// <value>
        /// The type of the security protocol.
        /// </value>
        /// <remarks>
        /// Lets you override the SecurityProtocolType. Defaults to TLS.
        /// </remarks>
        public SecurityProtocolType SecurityProtocol { get; set; }

        /// <summary>
        /// Gets or sets the server certificate validation callback.
        /// </summary>
        /// <value>
        /// The server certificate validation callback.
        /// </value>
        public RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [keep alive].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [keep alive]; otherwise, <c>false</c>.
        /// </value>
        public bool KeepAlive { get; set; }

        /// <summary>
        /// Converts this instance to a <see cref="WebRequest"/>
        /// </summary>
        /// <returns></returns>
        public WebRequest ToWebRequest()
        {
            var request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = Verb.ToString().ToUpper();
            request.Timeout = Timeout;
            request.ContentType = ContentType;
            request.Referer = Referer;
            request.AllowAutoRedirect = AllowAutoRedirect;
            request.KeepAlive = KeepAlive;

            request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip,deflate");
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            if (!string.IsNullOrEmpty(UserAgent)) request.UserAgent = UserAgent;
            if (!string.IsNullOrEmpty(Host)) request.Host = Host;
            if (!string.IsNullOrWhiteSpace(Accept)) request.Accept = Accept;

            request.Proxy = Proxy != null ? Proxy.ToWebProxy() : WebRequest.DefaultWebProxy;

            request.Headers.Add(Headers);
            request.CookieContainer = Cookies;

            ServicePointManager.SecurityProtocol =  SecurityProtocol;

            request.ServerCertificateValidationCallback += ServerCertificateValidationCallback;
            
            if (UseAuthentication)
            {
                if (UseBasicAuthentication)
                {
                    var header = string.Concat(Username, ":", Password);

                    var encoded = Convert.ToBase64String(Encoding.Default.GetBytes(header));

                    request.Headers["Authorization"] = $"Basic {encoded}";
                }
                else
                {
                    request.Credentials = new NetworkCredential(Username, Password);
                }
            }

            return request;
        }     
    }
}
