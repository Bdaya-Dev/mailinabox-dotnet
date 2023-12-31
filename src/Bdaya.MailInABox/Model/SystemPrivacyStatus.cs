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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Bdaya.MailInABox.Client.ClientUtils;

namespace Bdaya.MailInABox.Model
{
    /// <summary>
    /// System privacy status.
    /// </summary>
    /// <value>System privacy status.</value>
    public enum SystemPrivacyStatus
    {
        /// <summary>
        /// Enum Private for value: private
        /// </summary>
        Private = 1,

        /// <summary>
        /// Enum Off for value: off
        /// </summary>
        Off = 2
    }

    /// <summary>
    /// Converts <see cref="SystemPrivacyStatus"/> to and from the JSON value
    /// </summary>
    public static class SystemPrivacyStatusValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="SystemPrivacyStatus"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SystemPrivacyStatus FromString(string value)
        {
            if (value.Equals("private"))
                return SystemPrivacyStatus.Private;

            if (value.Equals("off"))
                return SystemPrivacyStatus.Off;

            throw new NotImplementedException($"Could not convert value to type SystemPrivacyStatus: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="SystemPrivacyStatus"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SystemPrivacyStatus? FromStringOrDefault(string value)
        {
            if (value.Equals("private"))
                return SystemPrivacyStatus.Private;

            if (value.Equals("off"))
                return SystemPrivacyStatus.Off;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="SystemPrivacyStatus"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(SystemPrivacyStatus value)
        {
            if (value == SystemPrivacyStatus.Private)
                return "private";

            if (value == SystemPrivacyStatus.Off)
                return "off";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="SystemPrivacyStatus"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class SystemPrivacyStatusJsonConverter : JsonConverter<SystemPrivacyStatus>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override SystemPrivacyStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            SystemPrivacyStatus? result = rawValue == null
                ? null
                : SystemPrivacyStatusValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the SystemPrivacyStatus to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="systemPrivacyStatus"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, SystemPrivacyStatus systemPrivacyStatus, JsonSerializerOptions options)
        {
            writer.WriteStringValue(systemPrivacyStatus.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="SystemPrivacyStatus"/>
    /// </summary>
    public class SystemPrivacyStatusNullableJsonConverter : JsonConverter<SystemPrivacyStatus?>
    {
        /// <summary>
        /// Returns a SystemPrivacyStatus from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override SystemPrivacyStatus? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            SystemPrivacyStatus? result = rawValue == null
                ? null
                : SystemPrivacyStatusValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="systemPrivacyStatus"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, SystemPrivacyStatus? systemPrivacyStatus, JsonSerializerOptions options)
        {
            writer.WriteStringValue(systemPrivacyStatus?.ToString() ?? "null");
        }
    }
}
