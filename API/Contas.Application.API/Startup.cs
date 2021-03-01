using Contas.Application.API.Configurations.Setup;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace Contas.Application.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

            builder.AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureServiceDatabase(Configuration.GetConnectionString("DefaultConnection"));
            services.ConfigureServiceDIs();
            services.ConfigureServiceCors();
            services.ConfigureServiceSwagger();
            services.ConfigureServiceMapper();

            services
                .AddControllers()
                .AddFluentValidation();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.ConfigureAppCors();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.ConfigureAppSwagger();
        }
    }
}
