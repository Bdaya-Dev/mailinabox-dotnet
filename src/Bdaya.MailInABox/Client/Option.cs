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


namespace Bdaya.MailInABox.Client
{
    /// <summary>
    /// A wrapper for operation parameters which are not required
    /// </summary>
    public struct Option<TType>
    {
        /// <summary>
        /// The value to send to the server
        /// </summary>
        public TType Value { get; }

        /// <summary>
        /// When true the value will be sent to the server
        /// </summary>
        internal bool IsSet { get; }

        /// <summary>
        /// A wrapper for operation parameters which are not required
        /// </summary>
        /// <param name="value"></param>
        public Option(TType value)
        {
            IsSet = true;
            Value = value;
        }
    }
}