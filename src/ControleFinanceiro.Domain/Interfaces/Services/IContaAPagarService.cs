using System.Threading.Tasks;
using ControleFinanceiro.Domain.Dtos;
using ControleFinanceiro.Domain.Models;
using ControleFinanceiro.Domain.Validations;

namespace ControleFinanceiro.Domain.Interfaces.Services
{
    public interface IContaAPagarService : IService<ContaAPagar>
    {
         Task<IValidationResult> RegistraContaAPagar(ContaAPagarInsertDto contaAPagar);
    }
}
