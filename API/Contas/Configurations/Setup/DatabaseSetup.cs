using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Contas.Repository.Context;

namespace Contas.Configurations.Setup
{
    public static class DatabaseSetup
    {
        public static void ConfigureServiceDatabase(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<EntityContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
