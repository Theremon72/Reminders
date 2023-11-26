using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;

namespace Reminders.Extensions.Swagger
{
    public static class SwaggerUIBuilderExtensions
    {
        /// <summary>
        /// Register the SwaggerUI Json Types
        /// </summary>
        public static IServiceCollection AddSwaggerJsonMaps(this IServiceCollection services)
        {
            services.AddSwaggerGen(c => c.MapType<TimeSpan>(() => new OpenApiSchema
            {
                Type = "string",
                Example = new OpenApiString("00:00:00")
            }));
            services.AddSwaggerGen(c => c.MapType<TimeOnly>(() => new OpenApiSchema
            {
                Type = "string",
                Example = new OpenApiString("00:00:00")
            }));


            return services;
        }
    }
}
