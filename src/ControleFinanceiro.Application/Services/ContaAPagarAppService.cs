using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Internal;
using ControleFinanceiro.Application.Interfaces;
using ControleFinanceiro.Application.ViewModels;
using ControleFinanceiro.Domain.Dtos;
using ControleFinanceiro.Domain.Interfaces.Repositories;
using ControleFinanceiro.Domain.Interfaces.Services;
using ControleFinanceiro.Domain.Validations;

namespace ControleFinanceiro.Application.Services
{
    public class ContaAPagarAppService : IContaAPagarAppService
    {
        private readonly IMapper _mapper;
        private readonly IContaAPagarService _contaAPagarService;
        private readonly IContaAPagarRepository _contaAPagarRepository;

        public ContaAPagarAppService(IContaAPagarService contaAPagarService, IContaAPagarRepository contaAPagarRepository, IMapper mapper)
        {
            _contaAPagarService = contaAPagarService;
            _contaAPagarRepository = contaAPagarRepository;
            _mapper = mapper;
        }

        public async Task<IList<ContaAPagarViewModel>> GetAllAsync()
        {
            var results = await _contaAPagarRepository.SelectAllAsync();
            return _mapper.Map<IList<ContaAPagarViewModel>>(results);
        }

        public Task<IValidationResult> CreateAsync(ContaAPagarInsertViewModel contaAPagar)
        {
            var contaAPagarDto = _mapper.Map<ContaAPagarInsertDto>(contaAPagar);
            return _contaAPagarService.RegistraContaAPagar(contaAPagarDto);
        }
    }
}
