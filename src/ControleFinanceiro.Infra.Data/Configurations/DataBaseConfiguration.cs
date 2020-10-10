using System;
using System.Runtime.Serialization.Formatters;
using ControleFinanceiro.Domain.Interfaces.Repositories;
using ControleFinanceiro.Infra.Data.Context;
using ControleFinanceiro.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ControleFinanceiro.Infra.Data.Configurations
{
    public static class DataBaseConfiguration
    {
        public static void AddDataBaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            services.AddDbContext<AppDbContext>(options => 
                options.UseMySql(configuration.GetConnectionString("ControleFinanceiro"),
                b => b.MigrationsAssembly("ControleFinanceiro.Services.Api")));
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IContaAPagarRepository, ContaAPagarRepository>();
        }
    }
}
