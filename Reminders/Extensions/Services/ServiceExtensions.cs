using Reminders.Reminders;
using Reminders.Reminders.Interfaces;

namespace Reminders.Extensions.Services
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(
             this IServiceCollection services)
        {
            services.AddTransient<IReminderService, ReminderService>();
            return services;
        }
    }
}
