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
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Model;

namespace Bdaya.MailInABox.Client
{
    /// <summary>
    /// Provides hosting configuration for Bdaya.MailInABox
    /// </summary>
    public class HostConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new DateTimeJsonConverter());
            _jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
            _jsonOptions.Converters.Add(new DNSCustomRecordJsonConverter());
            _jsonOptions.Converters.Add(new DNSDumpDomainRecordJsonConverter());
            _jsonOptions.Converters.Add(new DNSDumpDomainsInnerJsonConverter());
            _jsonOptions.Converters.Add(new DNSRecordTypeJsonConverter());
            _jsonOptions.Converters.Add(new DNSRecordTypeNullableJsonConverter());
            _jsonOptions.Converters.Add(new DNSSecondaryNameserverResponseJsonConverter());
            _jsonOptions.Converters.Add(new LogoutResponseJsonConverter());
            _jsonOptions.Converters.Add(new MailAliasJsonConverter());
            _jsonOptions.Converters.Add(new MailAliasByDomainJsonConverter());
            _jsonOptions.Converters.Add(new MailAliasesResponseFormatJsonConverter());
            _jsonOptions.Converters.Add(new MailAliasesResponseFormatNullableJsonConverter());
            _jsonOptions.Converters.Add(new MailUserJsonConverter());
            _jsonOptions.Converters.Add(new MailUserByDomainJsonConverter());
            _jsonOptions.Converters.Add(new MailUserPrivilegeJsonConverter());
            _jsonOptions.Converters.Add(new MailUserPrivilegeNullableJsonConverter());
            _jsonOptions.Converters.Add(new MailUserStatusJsonConverter());
            _jsonOptions.Converters.Add(new MailUserStatusNullableJsonConverter());
            _jsonOptions.Converters.Add(new MailUsersResponseFormatJsonConverter());
            _jsonOptions.Converters.Add(new MailUsersResponseFormatNullableJsonConverter());
            _jsonOptions.Converters.Add(new MeAuthStatusJsonConverter());
            _jsonOptions.Converters.Add(new MeAuthStatusNullableJsonConverter());
            _jsonOptions.Converters.Add(new MeResponseJsonConverter());
            _jsonOptions.Converters.Add(new MfaStatusResponseJsonConverter());
            _jsonOptions.Converters.Add(new MfaStatusResponseEnabledMfaJsonConverter());
            _jsonOptions.Converters.Add(new MfaStatusResponseNewMfaJsonConverter());
            _jsonOptions.Converters.Add(new SSLCertificatesProvisionResponseJsonConverter());
            _jsonOptions.Converters.Add(
                new SSLCertificatesProvisionResponseRequestsInnerJsonConverter()
            );
            _jsonOptions.Converters.Add(new SSLStatusJsonConverter());
            _jsonOptions.Converters.Add(new SSLStatusResponseJsonConverter());
            _jsonOptions.Converters.Add(new SSLStatusTypeJsonConverter());
            _jsonOptions.Converters.Add(new SSLStatusTypeNullableJsonConverter());
            _jsonOptions.Converters.Add(new StatusEntryJsonConverter());
            _jsonOptions.Converters.Add(new StatusEntryExtraJsonConverter());
            _jsonOptions.Converters.Add(new StatusEntryTypeJsonConverter());
            _jsonOptions.Converters.Add(new StatusEntryTypeNullableJsonConverter());
            _jsonOptions.Converters.Add(new SystemBackupConfigResponseJsonConverter());
            _jsonOptions.Converters.Add(new SystemBackupStatusJsonConverter());
            _jsonOptions.Converters.Add(new SystemBackupStatusResponseJsonConverter());
            _jsonOptions.Converters.Add(new SystemPrivacyStatusJsonConverter());
            _jsonOptions.Converters.Add(new SystemPrivacyStatusNullableJsonConverter());
            _jsonOptions.Converters.Add(new WebDomainJsonConverter());
            _jsonOptions.Converters.Add(new WebDomainSslCertificateInnerJsonConverter());
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider = new(_jsonOptions);
            _services.AddSingleton(jsonSerializerOptionsProvider);
            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddSingleton<DNSApiEvents>();
            _services.AddTransient<IDNSApi, DNSApi>();
            _services.AddSingleton<MFAApiEvents>();
            _services.AddTransient<IMFAApi, MFAApi>();
            _services.AddSingleton<MailApiEvents>();
            _services.AddTransient<IMailApi, MailApi>();
            _services.AddSingleton<SSLApiEvents>();
            _services.AddTransient<ISSLApi, SSLApi>();
            _services.AddSingleton<SystemApiEvents>();
            _services.AddTransient<ISystemApi, SystemApi>();
            _services.AddSingleton<UserApiEvents>();
            _services.AddTransient<IUserApi, UserApi>();
            _services.AddSingleton<WebApiEvents>();
            _services.AddTransient<IWebApi, WebApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="configureClient"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddApiHttpClients(
            Action<HttpClient>? configureClient = null,
            Action<IHttpClientBuilder>? builder = null
        )
        {
            configureClient ??= c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            var builders = new List<IHttpClientBuilder>
            {
                _services.AddHttpClient<IDNSApi, DNSApi>(configureClient),
                _services.AddHttpClient<IMFAApi, MFAApi>(configureClient),
                _services.AddHttpClient<IMailApi, MailApi>(configureClient),
                _services.AddHttpClient<ISSLApi, SSLApi>(configureClient),
                _services.AddHttpClient<ISystemApi, SystemApi>(configureClient),
                _services.AddHttpClient<IUserApi, UserApi>(configureClient),
                _services.AddHttpClient<IWebApi, WebApi>(configureClient)
            };

            if (builder != null)
                foreach (var instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(_jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(TTokenBase token)
            where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[] { token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens)
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<ITokenContainer<TTokenBase>>(new TokenContainer<TTokenBase>(tokens));

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration UseProvider<TTokenProvider, TTokenBase>()
            where TTokenProvider : class, ITokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<ITokenProvider<TTokenBase>, TTokenProvider>();
            return this;
        }
    }
}