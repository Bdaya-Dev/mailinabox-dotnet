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
    /// Mail user privilege.
    /// </summary>
    /// <value>Mail user privilege.</value>
    public enum MailUserPrivilege
    {
        /// <summary>
        /// Enum Admin for value: admin
        /// </summary>
        Admin = 1,

        /// <summary>
        /// Enum Empty for value: 
        /// </summary>
        Empty = 2
    }

    /// <summary>
    /// Converts <see cref="MailUserPrivilege"/> to and from the JSON value
    /// </summary>
    public static class MailUserPrivilegeValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="MailUserPrivilege"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MailUserPrivilege FromString(string value)
        {
            if (value.Equals("admin"))
                return MailUserPrivilege.Admin;

            if (value.Equals(""))
                return MailUserPrivilege.Empty;

            throw new NotImplementedException($"Could not convert value to type MailUserPrivilege: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="MailUserPrivilege"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static MailUserPrivilege? FromStringOrDefault(string value)
        {
            if (value.Equals("admin"))
                return MailUserPrivilege.Admin;

            if (value.Equals(""))
                return MailUserPrivilege.Empty;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="MailUserPrivilege"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(MailUserPrivilege value)
        {
            if (value == MailUserPrivilege.Admin)
                return "admin";

            if (value == MailUserPrivilege.Empty)
                return "";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="MailUserPrivilege"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class MailUserPrivilegeJsonConverter : JsonConverter<MailUserPrivilege>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override MailUserPrivilege Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            MailUserPrivilege? result = rawValue == null
                ? null
                : MailUserPrivilegeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the MailUserPrivilege to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mailUserPrivilege"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, MailUserPrivilege mailUserPrivilege, JsonSerializerOptions options)
        {
            writer.WriteStringValue(mailUserPrivilege.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="MailUserPrivilege"/>
    /// </summary>
    public class MailUserPrivilegeNullableJsonConverter : JsonConverter<MailUserPrivilege?>
    {
        /// <summary>
        /// Returns a MailUserPrivilege from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override MailUserPrivilege? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            MailUserPrivilege? result = rawValue == null
                ? null
                : MailUserPrivilegeValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mailUserPrivilege"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, MailUserPrivilege? mailUserPrivilege, JsonSerializerOptions options)
        {
            writer.WriteStringValue(mailUserPrivilege?.ToString() ?? "null");
        }
    }
}