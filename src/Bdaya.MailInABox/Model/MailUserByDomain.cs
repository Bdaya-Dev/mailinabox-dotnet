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
    /// Mail users by domain.
    /// </summary>
    public partial class MailUserByDomain : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailUserByDomain" /> class.
        /// </summary>
        /// <param name="domain">Hostname format.</param>
        /// <param name="users">users</param>
        [JsonConstructor]
        public MailUserByDomain(string domain, List<MailUser> users)
        {
            Domain = domain;
            Users = users;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Hostname format.
        /// </summary>
        /// <value>Hostname format.</value>
        /// <example>example.com</example>
        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or Sets Users
        /// </summary>
        [JsonPropertyName("users")]
        public List<MailUser> Users { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MailUserByDomain {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="MailUserByDomain" />
    /// </summary>
    public class MailUserByDomainJsonConverter : JsonConverter<MailUserByDomain>
    {
        /// <summary>
        /// Deserializes json to <see cref="MailUserByDomain" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MailUserByDomain Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string? domain = default;
            List<MailUser>? users = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "domain":
                            domain = utf8JsonReader.GetString();
                            break;
                        case "users":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                users = JsonSerializer.Deserialize<List<MailUser>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (domain == null)
                throw new ArgumentNullException(nameof(domain), "Property is required for class MailUserByDomain.");

            if (users == null)
                throw new ArgumentNullException(nameof(users), "Property is required for class MailUserByDomain.");

            return new MailUserByDomain(domain, users);
        }

        /// <summary>
        /// Serializes a <see cref="MailUserByDomain" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mailUserByDomain"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MailUserByDomain mailUserByDomain, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, mailUserByDomain, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="MailUserByDomain" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mailUserByDomain"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, MailUserByDomain mailUserByDomain, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("domain", mailUserByDomain.Domain);
            writer.WritePropertyName("users");
            JsonSerializer.Serialize(writer, mailUserByDomain.Users, jsonSerializerOptions);
        }
    }
}
