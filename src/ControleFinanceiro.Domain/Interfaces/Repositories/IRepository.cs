using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ControleFinanceiro.Domain.Models;
using ControleFinanceiro.Domain.Validations;

namespace ControleFinanceiro.Domain.Interfaces.Repositories
{
    public interface IRepository<T> : IDisposable where T : BaseModel
    {
         Task<T> SelectAsync(Guid id);
         Task<IList<T>> SelectAllAsync();

         Task InsertAsync(T model);
         Task UpdateAsync(T model);
         Task DeleteAsync(Guid id);

         Task<ValidationResult> SaveChangesAsync();
         ValidationResult SaveChanges();
    }
}
