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
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace Bdaya.MailInABox.Client
{
    /// <summary>
    /// Provides a non-generic contract for the ApiResponse wrapper.
    /// </summary>
    public interface IApiResponse
    {
        /// <summary>
        /// The type that represents the server's response.
        /// </summary>
        Type ResponseType { get; }

        /// <summary>
        /// Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The raw content of this response.
        /// </summary>
        string RawContent { get; }

        /// <summary>
        /// The DateTime when the request was retrieved.
        /// </summary>
        DateTime DownloadedAt { get; }

        /// <summary>
        /// The path used when making the request.
        /// </summary>
        string Path { get; }

        /// <summary>
        /// The Uri used when making the request.
        /// </summary>
        Uri? RequestUri { get; }
    }

    /// <summary>
    /// API Response
    /// </summary>
    public partial class ApiResponse<T> : IApiResponse
    {
        /// <summary>
        /// Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// The type that represents the server's response.
        /// </summary>
        public Type ResponseType
        {
            get { return typeof(T); }
        }

        /// <summary>
        /// The raw data
        /// </summary>
        public string RawContent { get; private set; }

        /// <summary>
        /// The IsSuccessStatusCode from the api response
        /// </summary>
        public bool IsSuccessStatusCode { get; }

        /// <summary>
        /// The reason phrase contained in the api response
        /// </summary>
        public string? ReasonPhrase { get; }

        /// <summary>
        /// The headers contained in the api response
        /// </summary>
        public System.Net.Http.Headers.HttpResponseHeaders Headers { get; }

        /// <summary>
        /// The DateTime when the request was retrieved.
        /// </summary>
        public DateTime DownloadedAt { get; } = DateTime.UtcNow;

        /// <summary>
        /// The DateTime when the request was sent.
        /// </summary>
        public DateTime RequestedAt { get; }

        /// <summary>
        /// The path used when making the request.
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// The Uri used when making the request.
        /// </summary>
        public Uri? RequestUri { get; }

        /// <summary>
        /// The JsonSerialzierOptions
        /// </summary>
        private System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// Construct the response using an HttpResponseMessage
        /// </summary>
        /// <param name="httpRequestMessage"></param>
        /// <param name="httpResponseMessage"></param>
        /// <param name="rawContent"></param>
        /// <param name="path"></param>
        /// <param name="requestedAt"></param>
        /// <param name="jsonSerializerOptions"></param>
        public ApiResponse(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions)
        {
            StatusCode = httpResponseMessage.StatusCode;
            Headers = httpResponseMessage.Headers;
            IsSuccessStatusCode = httpResponseMessage.IsSuccessStatusCode;
            ReasonPhrase = httpResponseMessage.ReasonPhrase;
            RawContent = rawContent;
            Path = path;
            RequestUri = httpRequestMessage.RequestUri;
            RequestedAt = requestedAt;
            _jsonSerializerOptions = jsonSerializerOptions;
            OnCreated(httpRequestMessage, httpResponseMessage);
        }

        partial void OnCreated(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Deserializes the server's response
        /// </summary>
        public T? AsModel()
        {
            if (!IsSuccessStatusCode)
            {
                return default(T?);
            }

            if (RawContent is T)
            {
                return (T)(object)RawContent;
            }
            if (typeof(T).IsPrimitive)
            {
                return (T)Convert.ChangeType(RawContent, typeof(T));
            }
            // This logic may be modified with the AsModel.mustache template
            return System.Text.Json.JsonSerializer.Deserialize<T>(RawContent, _jsonSerializerOptions);
        }

        /// <summary>
        /// Returns true when the model can be deserialized
        /// </summary>
        public bool TryToModel([NotNullWhen(true)] out T? model)
        {
            try
            {
                model = AsModel();
                return model != null;
            }
            catch
            {
                model = default(T);
                return false;
            }
        }
    }
}
