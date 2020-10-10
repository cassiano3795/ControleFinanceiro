using AutoMapper;
using ControleFinanceiro.Domain.Dtos;
using ControleFinanceiro.Domain.Models;

namespace ControleFinanceiro.Application.AutoMapper
{
    public class DtoToModelMappingProfile : Profile
    {
        public DtoToModelMappingProfile()
        {
            CreateMap<ContaAPagarInsertDto, ContaAPagar>()
                .ForMember(p => p.ValorOriginal, m => m.MapFrom(p => p.Valor));
        }
    }
}
