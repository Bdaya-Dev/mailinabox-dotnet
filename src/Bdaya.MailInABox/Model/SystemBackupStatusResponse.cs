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
    /// Backup status response. Lists the status for all backups.
    /// </summary>
    public partial class SystemBackupStatusResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemBackupStatusResponse" /> class.
        /// </summary>
        /// <param name="backups">backups</param>
        /// <param name="error">error</param>
        /// <param name="unmatchedFileSize">unmatchedFileSize</param>
        [JsonConstructor]
        public SystemBackupStatusResponse(List<SystemBackupStatus> backups, string error, int unmatchedFileSize)
        {
            Backups = backups;
            Error = error;
            UnmatchedFileSize = unmatchedFileSize;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Backups
        /// </summary>
        [JsonPropertyName("backups")]
        public List<SystemBackupStatus> Backups { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        /// <example>Something is wrong with the backup</example>
        [JsonPropertyName("error")]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets UnmatchedFileSize
        /// </summary>
        /// <example>0</example>
        [JsonPropertyName("unmatched_file_size")]
        public int UnmatchedFileSize { get; set; }

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
            sb.Append("class SystemBackupStatusResponse {\n");
            sb.Append("  Backups: ").Append(Backups).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  UnmatchedFileSize: ").Append(UnmatchedFileSize).Append("\n");
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
    /// A Json converter for type <see cref="SystemBackupStatusResponse" />
    /// </summary>
    public class SystemBackupStatusResponseJsonConverter : JsonConverter<SystemBackupStatusResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="SystemBackupStatusResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override SystemBackupStatusResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            List<SystemBackupStatus>? backups = default;
            string? error = default;
            int? unmatchedFileSize = default;

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
                        case "backups":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                backups = JsonSerializer.Deserialize<List<SystemBackupStatus>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "error":
                            error = utf8JsonReader.GetString();
                            break;
                        case "unmatched_file_size":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                unmatchedFileSize = utf8JsonReader.GetInt32();
                            break;
                        default:
                            break;
                    }
                }
            }

            if (backups == null)
                throw new ArgumentNullException(nameof(backups), "Property is required for class SystemBackupStatusResponse.");

            if (error == null)
                throw new ArgumentNullException(nameof(error), "Property is required for class SystemBackupStatusResponse.");

            if (unmatchedFileSize == null)
                throw new ArgumentNullException(nameof(unmatchedFileSize), "Property is required for class SystemBackupStatusResponse.");

            return new SystemBackupStatusResponse(backups, error, unmatchedFileSize.Value);
        }

        /// <summary>
        /// Serializes a <see cref="SystemBackupStatusResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="systemBackupStatusResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, SystemBackupStatusResponse systemBackupStatusResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, systemBackupStatusResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="SystemBackupStatusResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="systemBackupStatusResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, SystemBackupStatusResponse systemBackupStatusResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WritePropertyName("backups");
            JsonSerializer.Serialize(writer, systemBackupStatusResponse.Backups, jsonSerializerOptions);
            writer.WriteString("error", systemBackupStatusResponse.Error);
            writer.WriteNumber("unmatched_file_size", systemBackupStatusResponse.UnmatchedFileSize);
        }
    }
}
