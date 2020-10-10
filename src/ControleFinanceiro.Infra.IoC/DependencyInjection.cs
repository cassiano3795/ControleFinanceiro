using System;
using ControleFinanceiro.Application.Configurations;
using ControleFinanceiro.Domain.Services.Configurations;
using ControleFinanceiro.Infra.Data.Configurations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ControleFinanceiro.Infra.IoC
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            // ADD DBCONTEXT
            services.AddDataBaseConfiguration(configuration);

            // ADD REPOSITORIES
            services.AddRepositories();

            // ADD DOMAIN SERVICES
            services.AddDomainServices();

            // ADD APP SERVICES
            services.AddAppServices();

            // ADD AUTOMAPPER
            services.AddAutoMapperProfiles();
        }
    }
}
