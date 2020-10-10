using System;
using ControleFinanceiro.Domain.Interfaces.Services;
using ControleFinanceiro.Domain.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ControleFinanceiro.Domain.Services.Configurations
{
    public static class DomainServicesConfiguration
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddScoped(typeof(IService<>), typeof(BaseService<>));
            services.AddScoped<IContaAPagarService, ContaAPagarService>();
        }
    }
}
