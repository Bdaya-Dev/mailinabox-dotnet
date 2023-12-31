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
    ///  Class for testing DNSApi
    /// </summary>
    public sealed class DNSApiTests : ApiTestsBase
    {
        private readonly IDNSApi _instance;

        public DNSApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IDNSApi>();
        }

        /// <summary>
        /// Test AddDnsCustomARecord
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task AddDnsCustomARecordAsyncTest()
        {
            string qname = default!;
            string body = default!;
            var response = await _instance.AddDnsCustomARecordAsync(qname, body);
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test AddDnsCustomRecord
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task AddDnsCustomRecordAsyncTest()
        {
            DNSRecordType rtype = default!;
            string qname = default!;
            string body = default!;
            var response = await _instance.AddDnsCustomRecordAsync(rtype, qname, body);
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test AddDnsSecondaryNameserver
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task AddDnsSecondaryNameserverAsyncTest()
        {
            string hostnames = default!;
            var response = await _instance.AddDnsSecondaryNameserverAsync(hostnames);
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test GetDnsCustomARecordsForQName
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDnsCustomARecordsForQNameAsyncTest()
        {
            string qname = default!;
            var response = await _instance.GetDnsCustomARecordsForQNameAsync(qname);
            var model = response.AsModel();
            Assert.IsType<List<DNSCustomRecord>>(model);
        }

        /// <summary>
        /// Test GetDnsCustomRecords
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDnsCustomRecordsAsyncTest()
        {
            var response = await _instance.GetDnsCustomRecordsAsync();
            var model = response.AsModel();
            Assert.IsType<List<DNSCustomRecord>>(model);
        }

        /// <summary>
        /// Test GetDnsCustomRecordsForQNameAndType
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDnsCustomRecordsForQNameAndTypeAsyncTest()
        {
            DNSRecordType rtype = default!;
            string qname = default!;
            var response = await _instance.GetDnsCustomRecordsForQNameAndTypeAsync(rtype, qname);
            var model = response.AsModel();
            Assert.IsType<List<DNSCustomRecord>>(model);
        }

        /// <summary>
        /// Test GetDnsDump
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDnsDumpAsyncTest()
        {
            var response = await _instance.GetDnsDumpAsync();
            var model = response.AsModel();
            Assert.IsType<List<List<DNSDumpDomainsInner>>>(model);
        }

        /// <summary>
        /// Test GetDnsSecondaryNameserver
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDnsSecondaryNameserverAsyncTest()
        {
            var response = await _instance.GetDnsSecondaryNameserverAsync();
            var model = response.AsModel();
            Assert.IsType<DNSSecondaryNameserverResponse>(model);
        }

        /// <summary>
        /// Test GetDnsZonefile
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDnsZonefileAsyncTest()
        {
            string zone = default!;
            var response = await _instance.GetDnsZonefileAsync(zone);
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test GetDnsZones
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetDnsZonesAsyncTest()
        {
            var response = await _instance.GetDnsZonesAsync();
            var model = response.AsModel();
            Assert.IsType<List<string>>(model);
        }

        /// <summary>
        /// Test RemoveDnsCustomARecord
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task RemoveDnsCustomARecordAsyncTest()
        {
            string qname = default!;
            string body = default!;
            var response = await _instance.RemoveDnsCustomARecordAsync(qname, body);
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test RemoveDnsCustomRecord
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task RemoveDnsCustomRecordAsyncTest()
        {
            DNSRecordType rtype = default!;
            string qname = default!;
            string body = default!;
            var response = await _instance.RemoveDnsCustomRecordAsync(rtype, qname, body);
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test UpdateDns
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateDnsAsyncTest()
        {
            int force = default!;
            var response = await _instance.UpdateDnsAsync(force);
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test UpdateDnsCustomARecord
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateDnsCustomARecordAsyncTest()
        {
            string qname = default!;
            string body = default!;
            var response = await _instance.UpdateDnsCustomARecordAsync(qname, body);
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }

        /// <summary>
        /// Test UpdateDnsCustomRecord
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UpdateDnsCustomRecordAsyncTest()
        {
            DNSRecordType rtype = default!;
            string qname = default!;
            string body = default!;
            var response = await _instance.UpdateDnsCustomRecordAsync(rtype, qname, body);
            var model = response.AsModel();
            Assert.IsType<string>(model);
        }
    }
}
