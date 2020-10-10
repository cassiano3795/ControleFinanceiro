using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ControleFinanceiro.Domain.Models;
using ControleFinanceiro.Domain.Validations;

namespace ControleFinanceiro.Domain.Interfaces.Services
{
    public interface IService<T> :IDisposable where T : BaseModel
    {
         Task<T> GetAsync(Guid id);
         Task<IList<T>> GetAllAsync();

         Task<ValidationResult> CreateAsync(T model);
         Task<ValidationResult> UpdateAsync(T model);
         Task<ValidationResult> RemoveAsync(Guid id);
    }
}
