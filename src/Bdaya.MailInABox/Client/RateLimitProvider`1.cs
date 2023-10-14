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
using System.Threading.Channels;

namespace Bdaya.MailInABox.Client 
{
    /// <summary>
    /// Provides a token to the api clients. Tokens will be rate limited based on the provided TimeSpan.
    /// </summary>
    /// <typeparam name="TTokenBase"></typeparam>
    public class RateLimitProvider<TTokenBase> : ITokenProvider<TTokenBase> where TTokenBase : TokenBase
    {
        internal Channel<TTokenBase> AvailableTokens { get; }
        private ITokenContainer<TTokenBase> TokenContainer { get; }
        /// <summary>
        /// Instantiates a ThrottledTokenProvider. Your tokens will be rate limited based on the token's timeout.
        /// </summary>
        /// <param name="container"></param>
        public RateLimitProvider(ITokenContainer<TTokenBase> container)
        {
            this.TokenContainer = container;
            var options = new UnboundedChannelOptions();
            AvailableTokens = Channel.CreateUnbounded<TTokenBase>(options);
        }
        public  async System.Threading.Tasks.ValueTask<TTokenBase> GetAsync(System.Threading.CancellationToken cancellation = default)
        {
            foreach (TTokenBase token in TokenContainer.Tokens)
            {
                token.StartTimer(token.Timeout ?? TimeSpan.FromMilliseconds(40));
                token.TokenBecameAvailable -= OnTokenBecameAvailable;
                token.TokenBecameAvailable += OnTokenBecameAvailable;
            }
            return await AvailableTokens.Reader.ReadAsync(cancellation).ConfigureAwait(false);
        }

        private void OnTokenBecameAvailable(object sender)
        {
            AvailableTokens.Writer.TryWrite((TTokenBase)sender);
        }
    }
} 