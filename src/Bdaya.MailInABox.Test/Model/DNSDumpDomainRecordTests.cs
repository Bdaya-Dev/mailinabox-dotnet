/*
 * Mail-in-a-Box
 *
 * Mail-in-a-Box API HTTP specification.  # Introduction This API is documented in [**OpenAPI format**](http://spec.openapis.org/oas/v3.0.3). ([View the full HTTP specification](https://raw.githubusercontent.com/mail-in-a-box/mailinabox/api-spec/api/mailinabox.yml).)  All endpoints are relative to `https://{host}/admin` and are secured with [`Basic Access` authentication](https://en.wikipedia.org/wiki/Basic_access_authentication). If you have multi-factor authentication enabled, authentication with a `user:password` combination will fail unless a valid OTP is supplied via the `x-auth-token` header. Authentication via a `user:user_key` pair is possible without the header being present. 
 *
 * The version of the OpenAPI document: 0.51.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Bdaya.MailInABox.Model;
using Bdaya.MailInABox.Client;
using System.Reflection;

namespace Bdaya.MailInABox.Test.Model
{
    /// <summary>
    ///  Class for testing DNSDumpDomainRecord
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DNSDumpDomainRecordTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DNSDumpDomainRecord
        //private DNSDumpDomainRecord instance;

        public DNSDumpDomainRecordTests()
        {
            // TODO uncomment below to create an instance of DNSDumpDomainRecord
            //instance = new DNSDumpDomainRecord();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DNSDumpDomainRecord
        /// </summary>
        [Fact]
        public void DNSDumpDomainRecordInstanceTest()
        {
            // TODO uncomment below to test "IsType" DNSDumpDomainRecord
            //Assert.IsType<DNSDumpDomainRecord>(instance);
        }

        /// <summary>
        /// Test the property 'Explanation'
        /// </summary>
        [Fact]
        public void ExplanationTest()
        {
            // TODO unit test for the property 'Explanation'
        }

        /// <summary>
        /// Test the property 'Qname'
        /// </summary>
        [Fact]
        public void QnameTest()
        {
            // TODO unit test for the property 'Qname'
        }

        /// <summary>
        /// Test the property 'Rtype'
        /// </summary>
        [Fact]
        public void RtypeTest()
        {
            // TODO unit test for the property 'Rtype'
        }

        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Fact]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }
    }
}
