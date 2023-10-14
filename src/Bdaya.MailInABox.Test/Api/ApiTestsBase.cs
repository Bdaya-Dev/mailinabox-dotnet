/*
 * Mail-in-a-Box
 *
 * Mail-in-a-Box API HTTP specification.  # Introduction This API is documented in [**OpenAPI format**](http://spec.openapis.org/oas/v3.0.3). ([View the full HTTP specification](https://raw.githubusercontent.com/mail-in-a-box/mailinabox/api-spec/api/mailinabox.yml).)  All endpoints are relative to `https://{host}/admin` and are secured with [`Basic Access` authentication](https://en.wikipedia.org/wiki/Basic_access_authentication). If you have multi-factor authentication enabled, authentication with a `user:password` combination will fail unless a valid OTP is supplied via the `x-auth-token` header. Authentication via a `user:user_key` pair is possible without the header being present.
 *
 * The version of the OpenAPI document: 0.51.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Bdaya.MailInABox.Api;
using Microsoft.Extensions.Hosting;
using Bdaya.MailInABox.Client;
using Bdaya.MailInABox.Extensions;
using Bdaya.MailInABox.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace Bdaya.MailInABox.Test.Api
{
    /// <summary>
    ///  Base class for API tests
    /// </summary>
    public class ApiTestsBase : IAsyncLifetime
    {
        protected readonly IHost _host;
        protected readonly ITokenContainer<BasicToken> _basicTokenContainer;

        protected ApiTestsBase(string[] args)
        {
            _host = CreateHostBuilder(args).Build();
            _basicTokenContainer = _host.Services.GetRequiredService<ITokenContainer<BasicToken>>();
        }

        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(conf => { conf.AddUserSecrets<ApiTestsBase>(optional: false); })
                .ConfigureApi(
                    (context, services, options) =>
                    {
                        // read: https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets
                        // To run the tests locally, you need the following secrets:
                        // miab:url, miab:username, miab:password
                        // you can also add them in appsettings.json
                        var section = context.Configuration.GetRequiredSection("miab");
                        var url = section.GetValue<string>("url");
                        if (url != null)
                        {
                            ClientUtils.BASE_ADDRESS = url;
                        }

                        var basicTokenUsername =
                            section.GetValue<string>("username")
                            ?? throw new Exception("Username not found.");
                        var basicTokenPassword =
                            section.GetValue<string>("password")
                            ?? throw new Exception("Password not found.");
                        BasicToken basicToken =
                            new(basicTokenUsername, basicTokenPassword, timeout: null);
                        options.AddTokens(basicToken);
                    }
                );

        protected virtual bool LoginInitially => true;

        protected virtual async Task<MeResponse> LoginAndReplaceToken()
        {
            var _instance = _host.Services.GetRequiredService<IUserApi>();
            var response = await _instance.LoginAsync();
            var model = response.AsModel();
            Assert.NotNull(model);
            Assert.NotNull(model.Email);
            Assert.NotNull(model.ApiKey);
            _basicTokenContainer.Tokens.Clear();
            _basicTokenContainer.Tokens.Add(new BasicToken(model.Email, model.ApiKey));
            return model;
        }

        protected virtual async Task LogoutAndRemoveToken()
        {
            var _instance = _host.Services.GetRequiredService<IUserApi>();
            await _instance.LogoutAsync();
            _basicTokenContainer.Tokens.Clear();
        }

        public Task InitializeAsync()
        {
            return LoginInitially ? LoginAndReplaceToken() : Task.CompletedTask;
        }

        public async Task DisposeAsync()
        {
            if (LoginInitially)
            {
                await LogoutAndRemoveToken();
            }
        }
    }
}