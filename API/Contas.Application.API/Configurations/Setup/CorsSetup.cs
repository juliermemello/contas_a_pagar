using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Contas.Application.API.Configurations.Setup
{
    public static class CorsSetup
    {
        private static string CorsPolicy = "localhost-policy";

        public static void ConfigureServiceCors(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddCors(options =>
            {
                options.AddPolicy(CorsPolicy,
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }

        public static void ConfigureAppCors(this IApplicationBuilder app)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));

            app.UseCors(CorsPolicy);
        }
    }
}
