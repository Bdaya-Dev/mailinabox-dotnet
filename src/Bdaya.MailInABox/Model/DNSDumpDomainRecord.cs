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
    /// Domain DNS record details.
    /// </summary>
    public partial class DNSDumpDomainRecord : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DNSDumpDomainRecord" /> class.
        /// </summary>
        /// <param name="explanation">explanation</param>
        /// <param name="qname">Hostname format.</param>
        /// <param name="rtype">rtype</param>
        /// <param name="value">value</param>
        [JsonConstructor]
        public DNSDumpDomainRecord(string explanation, string qname, DNSRecordType rtype, string value)
        {
            Explanation = explanation;
            Qname = qname;
            Rtype = rtype;
            Value = value;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Rtype
        /// </summary>
        [JsonPropertyName("rtype")]
        public DNSRecordType Rtype { get; set; }

        /// <summary>
        /// Gets or Sets Explanation
        /// </summary>
        /// <example>Required. Specifies the hostname (and priority) of the machine that handles @example.com mail</example>
        [JsonPropertyName("explanation")]
        public string Explanation { get; set; }

        /// <summary>
        /// Hostname format.
        /// </summary>
        /// <value>Hostname format.</value>
        /// <example>example.com</example>
        [JsonPropertyName("qname")]
        public string Qname { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        /// <example>10 example.com.</example>
        [JsonPropertyName("value")]
        public string Value { get; set; }

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
            sb.Append("class DNSDumpDomainRecord {\n");
            sb.Append("  Explanation: ").Append(Explanation).Append("\n");
            sb.Append("  Qname: ").Append(Qname).Append("\n");
            sb.Append("  Rtype: ").Append(Rtype).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
    /// A Json converter for type <see cref="DNSDumpDomainRecord" />
    /// </summary>
    public class DNSDumpDomainRecordJsonConverter : JsonConverter<DNSDumpDomainRecord>
    {
        /// <summary>
        /// Deserializes json to <see cref="DNSDumpDomainRecord" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DNSDumpDomainRecord Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string? explanation = default;
            string? qname = default;
            DNSRecordType? rtype = default;
            string? value = default;

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
                        case "explanation":
                            explanation = utf8JsonReader.GetString();
                            break;
                        case "qname":
                            qname = utf8JsonReader.GetString();
                            break;
                        case "rtype":
                            string? rtypeRawValue = utf8JsonReader.GetString();
                            rtype = rtypeRawValue == null
                                ? null
                                : DNSRecordTypeValueConverter.FromStringOrDefault(rtypeRawValue);
                            break;
                        case "value":
                            value = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (explanation == null)
                throw new ArgumentNullException(nameof(explanation), "Property is required for class DNSDumpDomainRecord.");

            if (qname == null)
                throw new ArgumentNullException(nameof(qname), "Property is required for class DNSDumpDomainRecord.");

            if (rtype == null)
                throw new ArgumentNullException(nameof(rtype), "Property is required for class DNSDumpDomainRecord.");

            if (value == null)
                throw new ArgumentNullException(nameof(value), "Property is required for class DNSDumpDomainRecord.");

            return new DNSDumpDomainRecord(explanation, qname, rtype.Value, value);
        }

        /// <summary>
        /// Serializes a <see cref="DNSDumpDomainRecord" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dNSDumpDomainRecord"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DNSDumpDomainRecord dNSDumpDomainRecord, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, dNSDumpDomainRecord, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DNSDumpDomainRecord" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dNSDumpDomainRecord"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, DNSDumpDomainRecord dNSDumpDomainRecord, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("explanation", dNSDumpDomainRecord.Explanation);
            writer.WriteString("qname", dNSDumpDomainRecord.Qname);
            var rtypeRawValue = DNSRecordTypeValueConverter.ToJsonValue(dNSDumpDomainRecord.Rtype);

            if (rtypeRawValue != null)
                writer.WriteString("rtype", rtypeRawValue);
            else
                writer.WriteNull("rtype");

            writer.WriteString("value", dNSDumpDomainRecord.Value);
        }
    }
}
