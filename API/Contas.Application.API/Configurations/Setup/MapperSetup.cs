using Microsoft.Extensions.DependencyInjection;
using System;

namespace Contas.Application.API.Configurations.Setup
{
    public static class MapperSetup
    {
        public static void ConfigureServiceMapper(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(Startup));
        }
    }
}
