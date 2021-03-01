using Contas.Domain.Interfaces.Repositories;
using Contas.Domain.Interfaces.Services;
using Contas.Domain.Models;
using Contas.Domain.RequestModels;
using Contas.Domain.Validators.Models;
using Contas.Domain.Validators.RequestModels;
using Contas.Repository.Context;
using Contas.Repository.Repositories;
using Contas.Service.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Contas.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddScoped<EntityContext>();

            services.AddScoped<IContaPagarRepository, ContaPagarRepository>();

            services.AddScoped<IContaPagarService, ContaPagarService>();

            services.AddTransient<IValidator<ContaPagar>, ContaPagarValidator>();
            services.AddTransient<IValidator<ContaPagarRequest>, ContaPagarRequestValidator>();
        }
    }
}
