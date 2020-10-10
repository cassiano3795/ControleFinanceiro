using System.Collections.Generic;
using System.Threading.Tasks;
using ControleFinanceiro.Application.ViewModels;
using ControleFinanceiro.Domain.Validations;

namespace ControleFinanceiro.Application.Interfaces
{
    public interface IContaAPagarAppService
    {
         Task<IList<ContaAPagarViewModel>> GetAllAsync();
         Task<IValidationResult> CreateAsync(ContaAPagarInsertViewModel contaAPagar);
    }
}
