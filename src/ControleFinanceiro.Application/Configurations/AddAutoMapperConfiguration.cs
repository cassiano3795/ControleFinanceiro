using System;
using AutoMapper;
using ControleFinanceiro.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace ControleFinanceiro.Application.Configurations
{
    public static class AddAutoMapperConfiguration
    {
        public static void AddAutoMapperProfiles(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(ModelToViewModelMappingProfile), typeof(ViewModelToDtoMappingProfile));
        }
    }
}
