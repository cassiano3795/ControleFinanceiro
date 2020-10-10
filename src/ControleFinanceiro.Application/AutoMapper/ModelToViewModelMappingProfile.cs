using AutoMapper;
using ControleFinanceiro.Application.ViewModels;
using ControleFinanceiro.Domain.Models;

namespace ControleFinanceiro.Application.AutoMapper
{
    public class ModelToViewModelMappingProfile : Profile
    {
        public ModelToViewModelMappingProfile()
        {
            // CONTA A PAGAR
            CreateMap<ContaAPagar, ContaAPagarViewModel>();
        }
    }
}
