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
    /// System entry extra information.
    /// </summary>
    public partial class StatusEntryExtra : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusEntryExtra" /> class.
        /// </summary>
        /// <param name="monospace">monospace</param>
        /// <param name="text">text</param>
        [JsonConstructor]
        public StatusEntryExtra(bool monospace, string text)
        {
            Monospace = monospace;
            Text = text;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Monospace
        /// </summary>
        /// <example>false</example>
        [JsonPropertyName("monospace")]
        public bool Monospace { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        /// <example>Digest Type: 2 / SHA-256</example>
        [JsonPropertyName("text")]
        public string Text { get; set; }

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
            sb.Append("class StatusEntryExtra {\n");
            sb.Append("  Monospace: ").Append(Monospace).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
    /// A Json converter for type <see cref="StatusEntryExtra" />
    /// </summary>
    public class StatusEntryExtraJsonConverter : JsonConverter<StatusEntryExtra>
    {
        /// <summary>
        /// Deserializes json to <see cref="StatusEntryExtra" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override StatusEntryExtra Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            bool? monospace = default;
            string? text = default;

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
                        case "monospace":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                monospace = utf8JsonReader.GetBoolean();
                            break;
                        case "text":
                            text = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (monospace == null)
                throw new ArgumentNullException(nameof(monospace), "Property is required for class StatusEntryExtra.");

            if (text == null)
                throw new ArgumentNullException(nameof(text), "Property is required for class StatusEntryExtra.");

            return new StatusEntryExtra(monospace.Value, text);
        }

        /// <summary>
        /// Serializes a <see cref="StatusEntryExtra" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="statusEntryExtra"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, StatusEntryExtra statusEntryExtra, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, statusEntryExtra, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="StatusEntryExtra" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="statusEntryExtra"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, StatusEntryExtra statusEntryExtra, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteBoolean("monospace", statusEntryExtra.Monospace);
            writer.WriteString("text", statusEntryExtra.Text);
        }
    }
}
