using Cryptocurrency.Quotation.Domain.Notifications;
using Microsoft.Extensions.DependencyInjection;

namespace Cryptocurrency.Quotation.Api.Dependencies
{
    public static class NotificationDependency
    {
        public static void AddNotifications(this IServiceCollection services)
        {
            _ = services.AddScoped<INotificationContext, NotificationContext>();
        }
    }
}
