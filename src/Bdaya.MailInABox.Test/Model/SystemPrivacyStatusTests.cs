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
    ///  Class for testing SystemPrivacyStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SystemPrivacyStatusTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SystemPrivacyStatus
        //private SystemPrivacyStatus instance;

        public SystemPrivacyStatusTests()
        {
            // TODO uncomment below to create an instance of SystemPrivacyStatus
            //instance = new SystemPrivacyStatus();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SystemPrivacyStatus
        /// </summary>
        [Fact]
        public void SystemPrivacyStatusInstanceTest()
        {
            // TODO uncomment below to test "IsType" SystemPrivacyStatus
            //Assert.IsType<SystemPrivacyStatus>(instance);
        }
    }
}