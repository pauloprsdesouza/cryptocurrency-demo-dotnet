using Cryptocurrency.Quotation.Infrastructure.Mappers;
using Microsoft.Extensions.DependencyInjection;

namespace Cryptocurrency.Quotation.Api.Dependencies
{
    public static class MapperProfileDependency
    {
        public static void AddMapperProfiles(this IServiceCollection services)
        {
            _ = services.AddAutoMapper(typeof(CryptocurrencyProfile), typeof(CryptoQuotationProfile));
        }
    }
}
