/*
 * Mail-in-a-Box
 *
 * Mail-in-a-Box API HTTP specification.  # Introduction This API is documented in [**OpenAPI format**](http://spec.openapis.org/oas/v3.0.3). ([View the full HTTP specification](https://raw.githubusercontent.com/mail-in-a-box/mailinabox/api-spec/api/mailinabox.yml).)  All endpoints are relative to `https://{host}/admin` and are secured with [`Basic Access` authentication](https://en.wikipedia.org/wiki/Basic_access_authentication). If you have multi-factor authentication enabled, authentication with a `user:password` combination will fail unless a valid OTP is supplied via the `x-auth-token` header. Authentication via a `user:user_key` pair is possible without the header being present. 
 *
 * The version of the OpenAPI document: 0.51.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Bdaya.MailInABox.Client
{
    /// <summary>
    /// Formatter for 'date' openapi formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.0.md#data-types
    /// </summary>
    public class DateTimeNullableJsonConverter : JsonConverter<DateTime?>
    {
        /// <summary>
        /// The formats used to deserialize the date
        /// </summary>
        public static string[] Formats { get; } = {
            "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK",
            "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'ffffffK",
            "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffK",
            "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'ffffK",
            "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffK",
            "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'ffK",
            "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fK",
            "yyyy'-'MM'-'dd'T'HH':'mm':'ssK",
            "yyyy'-'MM'-'dd",
            "yyyyMMddTHHmmss.fffffffK",
            "yyyyMMddTHHmmss.ffffffK",
            "yyyyMMddTHHmmss.fffffK",
            "yyyyMMddTHHmmss.ffffK",
            "yyyyMMddTHHmmss.fffK",
            "yyyyMMddTHHmmss.ffK",
            "yyyyMMddTHHmmss.fK",
            "yyyyMMddTHHmmssK",
            "yyyyMMdd"
         };

        /// <summary>
        /// Returns a DateTime from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            if (reader.TokenType == JsonTokenType.Null)
                return null;

            string value = reader.GetString()!;

            foreach(string format in Formats)
                if (DateTime.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out DateTime result))
                    return result;

            return null;
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="dateTimeValue"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, DateTime? dateTimeValue, JsonSerializerOptions options)
        {
            if (dateTimeValue == null)
                writer.WriteNullValue();
            else
                writer.WriteStringValue(dateTimeValue.Value.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK", CultureInfo.InvariantCulture));
        }
    }
}
