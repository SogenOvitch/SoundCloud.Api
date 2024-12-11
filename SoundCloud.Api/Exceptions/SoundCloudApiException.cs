using System;
using System.Net;
using System.Net.Http;

namespace SoundCloud.Api.Exceptions
{
    public class SoundCloudApiException : Exception
    {
        internal SoundCloudApiException(HttpStatusCode httpStatusCode, HttpContent httpContent, string? message = null) : base(message)
        {
            HttpStatusCode = httpStatusCode;
            HttpContent = httpContent;
        }

        public HttpStatusCode HttpStatusCode { get; }

        public HttpContent HttpContent { get; }
    }
}