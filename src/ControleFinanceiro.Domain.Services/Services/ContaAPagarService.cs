using System.Threading.Tasks;
using AutoMapper;
using ControleFinanceiro.Domain.Dtos;
using ControleFinanceiro.Domain.Interfaces.Repositories;
using ControleFinanceiro.Domain.Interfaces.Services;
using ControleFinanceiro.Domain.Models;
using ControleFinanceiro.Domain.Validations;
using ControleFinanceiro.Domain.Validations.ContaAPagarValidations.DataPagamento;

namespace ControleFinanceiro.Domain.Services.Services
{
    public class ContaAPagarService : BaseService<ContaAPagar>, IContaAPagarService
    {
        private readonly IMapper _mapper;
        private readonly IContaAPagarRepository _contaAPagarRepository;
        public ContaAPagarService(IContaAPagarRepository contaAPagarRepository, IMapper mapper) : base(contaAPagarRepository)
        {
            _mapper = mapper;
            _contaAPagarRepository = contaAPagarRepository;
        }

        public async Task<IValidationResult> RegistraContaAPagar(ContaAPagarInsertDto contaAPagar)
        {
            var contaAPagarModel = _mapper.Map<ContaAPagar>(contaAPagar);
            var aplicaJurosAte3Dias = new AplicaJurosAte3dias();
            var aplicaJurosAte5Dias = new AplicaJurosAte5Dias();
            var aplicaJurosMais5Dias = new AplicaJurosMais5Dias();

            aplicaJurosAte3Dias.Proximo = aplicaJurosAte5Dias;
            aplicaJurosAte5Dias.Proximo = aplicaJurosMais5Dias;
            aplicaJurosAte3Dias.Calcula(contaAPagarModel);

            await _contaAPagarRepository.InsertAsync(contaAPagarModel);
            var result = await _contaAPagarRepository.SaveChangesAsync();

            return result;
        }
    }
}
