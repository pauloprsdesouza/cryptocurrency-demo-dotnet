using Cryptocurrency.Quotation.Domain.Apis;
using Cryptocurrency.Quotation.Domain.Apis.CoinMarketCap;
using Cryptocurrency.Quotation.Infrastructure.Apis.CoinMarketCap;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Schedy.Connect.Api.Dependencies
{
    public static class ExternalApiDependency
    {
        public static void AddExternalApis(this IServiceCollection services, IConfiguration configuration)
        {
            _ = services.Configure<ExternalApiConfiguration>(configuration);

            _ = services.AddHttpClient("CoinMarketCapApi", client =>
            {
                client.BaseAddress = new Uri(configuration[nameof(ExternalApiConfiguration.Url)]);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", configuration[nameof(ExternalApiConfiguration.ApiKey)]);
            });

            _ = services.AddTransient<ICoinMarketCapApi, CoinMarketCapApi>();
        }
    }
}
