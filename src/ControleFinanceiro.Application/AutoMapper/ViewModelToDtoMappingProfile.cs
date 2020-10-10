using AutoMapper;
using ControleFinanceiro.Application.ViewModels;
using ControleFinanceiro.Domain.Dtos;

namespace ControleFinanceiro.Application.AutoMapper
{
    public class ViewModelToDtoMappingProfile : Profile
    {
        public ViewModelToDtoMappingProfile()
        {
            CreateMap<ContaAPagarInsertViewModel, ContaAPagarInsertDto>().ReverseMap();
        }
    }
}
