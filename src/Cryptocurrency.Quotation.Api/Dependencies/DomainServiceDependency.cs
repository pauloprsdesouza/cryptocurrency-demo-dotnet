using Cryptocurrency.Quotation.Application.Cryptocurrencies;
using Cryptocurrency.Quotation.Application.Quotations;
using Cryptocurrency.Quotation.Domain.Cryptocurrencies;
using Cryptocurrency.Quotation.Domain.Quotations;
using Microsoft.Extensions.DependencyInjection;

namespace Cryptocurrency.Quotation.Api.Dependencies
{
    public static class DomainServiceDependency
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICryptoInfoService, CryptoInfoService>();
            services.AddScoped<ICryptoQuotationService, CryptoQuotationService>();
        }
    }
}