using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace Contas.Application.API.Configurations.Setup
{
    public static class SwaggerSetup
    {
        public static void ConfigureServiceSwagger(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Contas Project",
                    Description = "Projeto para cadastro de contas a pagar.",
                    Contact = new OpenApiContact
                    {
                        Name = "Julierme Pereira Mello",
                        Email = "juliermemello@gmail.com"
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT",
                        Url = new Uri("https://github.com/juliermemello/contas/blob/master/LICENSE")
                    }
                });
            });
        }

        public static void ConfigureAppSwagger(this IApplicationBuilder app)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));

            app.UseSwagger();

            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "Contas Project API v1");
            });
        }
    }
}
