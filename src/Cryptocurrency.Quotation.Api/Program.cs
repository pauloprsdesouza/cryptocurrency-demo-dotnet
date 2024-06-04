using Cryptocurrency.Quotation.Api.Configurations;
using Cryptocurrency.Quotation.Api.Dependencies;
using Cryptocurrency.Quotation.Api.Filter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cryptocurrency.Quotation.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            ConfigureServices(builder.Services, builder.Configuration);
            ConfigureBuilder(builder);
        }

        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            _ = services.AddDefaultAWSOptions(configuration.GetAWSOptions());
            _ = services.AddControllers(options =>
            {
                AuthorizationPolicy policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();

                options.Filters.Add(new AuthorizeFilter(policy));
                _ = options.Filters.Add(typeof(ExceptionFilter));
                _ = options.Filters.Add(typeof(RequestValidationFilter));
                _ = options.Filters.Add(typeof(NotificationFilter));
            })
            .AddJsonOptions(options => options.JsonSerializerOptions.Default());

            //services.AddDefaultCorsPolicy();
            services.AddNotifications();
            services.AddServices();
            services.AddRepositories();
            services.AddMapperProfiles();
            services.AddSwaggerDocumentation();
            services.AddDbContextDependency(configuration);
            services.AddMemoryCache();

            //services.AddJwtAuthentication(configuration.GetSection("JWTConfigurations"));
        }

        private static void ConfigureBuilder(WebApplicationBuilder builder)
        {
            var app = builder.Build();

            app.UseSwaggerDocumentation();

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
