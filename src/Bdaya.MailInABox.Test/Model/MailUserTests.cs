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
    ///  Class for testing MailUser
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MailUserTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MailUser
        //private MailUser instance;

        public MailUserTests()
        {
            // TODO uncomment below to create an instance of MailUser
            //instance = new MailUser();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MailUser
        /// </summary>
        [Fact]
        public void MailUserInstanceTest()
        {
            // TODO uncomment below to test "IsType" MailUser
            //Assert.IsType<MailUser>(instance);
        }

        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }

        /// <summary>
        /// Test the property 'Mailbox'
        /// </summary>
        [Fact]
        public void MailboxTest()
        {
            // TODO unit test for the property 'Mailbox'
        }

        /// <summary>
        /// Test the property 'Privileges'
        /// </summary>
        [Fact]
        public void PrivilegesTest()
        {
            // TODO unit test for the property 'Privileges'
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
    }
}