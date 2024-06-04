using Microsoft.Extensions.DependencyInjection;

namespace Cryptocurrency.Quotation.Api.Dependencies
{
    public static class RepositoryDependency
    {
        public static void AddRepositories(this IServiceCollection services)
        {
           // = services.AddScoped<IUserRepository, UserRepository>();
           
        }
    }
}
