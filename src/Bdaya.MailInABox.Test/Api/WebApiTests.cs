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
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using Bdaya.MailInABox.Api;
using Bdaya.MailInABox.Model;


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
    ///  Class for testing WebApi
    /// </summary>
    public sealed class WebApiTests : ApiTestsBase
    {
        private readonly IWebApi _instance;

        public WebApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IWebApi>();
        }

        /// <summary>
        /// Test GetWebDomains
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetWebDomainsAsyncTest()
        {
            var response = await _instance.GetWebDomainsAsync();
            var model = response.AsModel();
            Assert.IsType<List<WebDomain>>(model);
        }

        /// <summary>
        /// Test UpdateWeb
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateWebAsyncTest()
        {
            var response = await _instance.UpdateWebAsync();
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }
    }
}