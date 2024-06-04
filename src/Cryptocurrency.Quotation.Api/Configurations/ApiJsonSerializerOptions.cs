using System.Text.Json;
using System.Text.Json.Serialization;

namespace Cryptocurrency.Quotation.Api.Configurations
{
    public static class ApiJsonSerializerOptions
    {
        public static JsonSerializerOptions Default(this JsonSerializerOptions options)
        {
            options.PropertyNameCaseInsensitive = true;
            options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            options.Converters.Add(new JsonStringEnumConverter());

            return options;
        }

        public static JsonSerializerOptions SnakeCaseLower(this JsonSerializerOptions options)
        {
            options.PropertyNameCaseInsensitive = true;
            options.PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower;
            options.Converters.Add(new JsonStringEnumConverter());

            return options;
        }
    }
}
