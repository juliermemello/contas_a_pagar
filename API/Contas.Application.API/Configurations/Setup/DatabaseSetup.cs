using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Contas.Repository.Context;
using System;

namespace Contas.Application.API.Configurations.Setup
{
    public static class DatabaseSetup
    {
        public static void ConfigureServiceDatabase(this IServiceCollection services, string connectionString)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<EntityContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
