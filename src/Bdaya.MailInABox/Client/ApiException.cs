// <auto-generated>
/*
 * Mail-in-a-Box
 *
 * Mail-in-a-Box API HTTP specification.  # Introduction This API is documented in [**OpenAPI format**](http://spec.openapis.org/oas/v3.0.3). ([View the full HTTP specification](https://raw.githubusercontent.com/mail-in-a-box/mailinabox/api-spec/api/mailinabox.yml).)  All endpoints are relative to `https://{host}/admin` and are secured with [`Basic Access` authentication](https://en.wikipedia.org/wiki/Basic_access_authentication). If you have multi-factor authentication enabled, authentication with a `user:password` combination will fail unless a valid OTP is supplied via the `x-auth-token` header. Authentication via a `user:user_key` pair is possible without the header being present. 
 *
 * The version of the OpenAPI document: 0.51.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;

namespace Bdaya.MailInABox.Client
{
    /// <summary>
    /// API Exception
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        /// The reason the api request failed
        /// </summary>
        public string? ReasonPhrase { get; }

        /// <summary>
        /// The HttpStatusCode
        /// </summary>
        public System.Net.HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The raw data returned by the api
        /// </summary>
        public string RawContent { get; }
        
        /// <summary>
        /// Construct the ApiException from parts of the response
        /// </summary>
        /// <param name="reasonPhrase"></param>
        /// <param name="statusCode"></param>
        /// <param name="rawContent"></param>
        public ApiException(string? reasonPhrase, System.Net.HttpStatusCode statusCode, string rawContent) : base(reasonPhrase ?? rawContent)
        {
            ReasonPhrase = reasonPhrase;

            StatusCode = statusCode;

            RawContent = rawContent;
        }
    }
}
