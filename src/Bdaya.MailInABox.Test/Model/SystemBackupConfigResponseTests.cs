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
    ///  Class for testing SystemBackupConfigResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SystemBackupConfigResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SystemBackupConfigResponse
        //private SystemBackupConfigResponse instance;

        public SystemBackupConfigResponseTests()
        {
            // TODO uncomment below to create an instance of SystemBackupConfigResponse
            //instance = new SystemBackupConfigResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SystemBackupConfigResponse
        /// </summary>
        [Fact]
        public void SystemBackupConfigResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" SystemBackupConfigResponse
            //Assert.IsType<SystemBackupConfigResponse>(instance);
        }

        /// <summary>
        /// Test the property 'EncPwFile'
        /// </summary>
        [Fact]
        public void EncPwFileTest()
        {
            // TODO unit test for the property 'EncPwFile'
        }

        /// <summary>
        /// Test the property 'FileTargetDirectory'
        /// </summary>
        [Fact]
        public void FileTargetDirectoryTest()
        {
            // TODO unit test for the property 'FileTargetDirectory'
        }

        /// <summary>
        /// Test the property 'MinAgeInDays'
        /// </summary>
        [Fact]
        public void MinAgeInDaysTest()
        {
            // TODO unit test for the property 'MinAgeInDays'
        }

        /// <summary>
        /// Test the property 'SshPubKey'
        /// </summary>
        [Fact]
        public void SshPubKeyTest()
        {
            // TODO unit test for the property 'SshPubKey'
        }

        /// <summary>
        /// Test the property 'Target'
        /// </summary>
        [Fact]
        public void TargetTest()
        {
            // TODO unit test for the property 'Target'
        }

        /// <summary>
        /// Test the property 'TargetPass'
        /// </summary>
        [Fact]
        public void TargetPassTest()
        {
            // TODO unit test for the property 'TargetPass'
        }

        /// <summary>
        /// Test the property 'TargetUser'
        /// </summary>
        [Fact]
        public void TargetUserTest()
        {
            // TODO unit test for the property 'TargetUser'
        }
    }
}
