using Microsoft.Extensions.DependencyInjection;
using Contas.CrossCutting.IoC;
using System;

namespace Contas.Configurations.Setup
{
    public static class DependencyInjectionSetup
    {
        public static void ConfigureServiceDIs(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
