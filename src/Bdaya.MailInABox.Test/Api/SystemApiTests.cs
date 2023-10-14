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
    ///  Class for testing SystemApi
    /// </summary>
    public sealed class SystemApiTests : ApiTestsBase
    {
        private readonly ISystemApi _instance;

        public SystemApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ISystemApi>();
        }

        /// <summary>
        /// Test GetSystemBackupConfig
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetSystemBackupConfigAsyncTest()
        {
            var response = await _instance.GetSystemBackupConfigAsync();
            var model = response.AsModel();
            Assert.IsType<SystemBackupConfigResponse>(model);
        }

        /// <summary>
        /// Test GetSystemBackupStatus
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetSystemBackupStatusAsyncTest()
        {
            var response = await _instance.GetSystemBackupStatusAsync();
            var model = response.AsModel();
            Assert.IsType<SystemBackupStatusResponse>(model);
        }

        /// <summary>
        /// Test GetSystemPrivacyStatus
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetSystemPrivacyStatusAsyncTest()
        {
            var response = await _instance.GetSystemPrivacyStatusAsync();
            var model = response.AsModel();
            Assert.IsType<bool>(model);
        }

        /// <summary>
        /// Test GetSystemRebootStatus
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetSystemRebootStatusAsyncTest()
        {
            var response = await _instance.GetSystemRebootStatusAsync();
            var model = response.AsModel();
            Assert.IsType<bool>(model);
        }

        /// <summary>
        /// Test GetSystemStatus
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetSystemStatusAsyncTest()
        {
            var response = await _instance.GetSystemStatusAsync();
            var model = response.AsModel();
            Assert.IsType<List<StatusEntry>>(model);
        }

        /// <summary>
        /// Test GetSystemUpdates
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetSystemUpdatesAsyncTest()
        {
            var response = await _instance.GetSystemUpdatesAsync();
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test GetSystemUpstreamVersion
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetSystemUpstreamVersionAsyncTest()
        {
            var response = await _instance.GetSystemUpstreamVersionAsync();
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test GetSystemVersion
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetSystemVersionAsyncTest()
        {
            var response = await _instance.GetSystemVersionAsync();
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test RebootSystem
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task RebootSystemAsyncTest()
        {
            var response = await _instance.RebootSystemAsync();
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test UpdateSystemBackupConfig
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateSystemBackupConfigAsyncTest()
        {
            int minAge = default!;
            string target = default!;
            string targetUser = default!;
            string targetPass = default!;
            var response = await _instance.UpdateSystemBackupConfigAsync(minAge, target, targetUser, targetPass);
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test UpdateSystemPackages
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateSystemPackagesAsyncTest()
        {
            var response = await _instance.UpdateSystemPackagesAsync();
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test UpdateSystemPrivacy
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateSystemPrivacyAsyncTest()
        {
            SystemPrivacyStatus value = default!;
            var response = await _instance.UpdateSystemPrivacyAsync(value);
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }
    }
}