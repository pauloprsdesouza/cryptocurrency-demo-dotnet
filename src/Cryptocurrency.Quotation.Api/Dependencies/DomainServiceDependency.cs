using Microsoft.Extensions.DependencyInjection;

namespace Cryptocurrency.Quotation.Api.Dependencies
{
    public static class DomainServiceDependency
    {
        public static void AddServices(this IServiceCollection services)
        {
           // _ = services.AddScoped<IUserService, UserService>();
           
        }
    }
}