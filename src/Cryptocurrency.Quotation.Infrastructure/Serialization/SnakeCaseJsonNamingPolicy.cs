using System.Text.Json;

namespace Cryptocurrency.Quotation.Infrastructure.Serialization
{
    public class SnakeCaseJsonNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            return ConvertSnakeToCamelCase(name);
        }

        private string ConvertSnakeToCamelCase(string name)
        {
            if (string.IsNullOrEmpty(name) || !name.Contains("_"))
                return name;

            var parts = name.Split('_');
            var result = parts[0];

            for (int i = 1; i < parts.Length; i++)
            {
                result += char.ToUpper(parts[i][0]) + parts[i].Substring(1);
            }

            return result;
        }
    }
}
