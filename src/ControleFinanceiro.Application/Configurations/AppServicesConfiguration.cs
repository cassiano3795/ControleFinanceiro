using System;
using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ControleFinanceiro.Application.Configurations
{
    public static class AppServicesConfiguration
    {
        public static void AddAppServices(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddScoped<IContaAPagarAppService, ContaAPagarAppService>();
        }
    }
}
