using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cryptocurrency.Quotation.Api.Dependencies
{
    public static class DBDependency
    {
        public static void AddDbContextDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAWSService<IAmazonDynamoDB>();
            services.AddScoped<IDynamoDBContext, DynamoDBContext>();
        }
    }
}