using ControleFinanceiro.Domain.Interfaces.Repositories;
using ControleFinanceiro.Domain.Models;
using ControleFinanceiro.Infra.Data.Context;

namespace ControleFinanceiro.Infra.Data.Repositories
{
    public class ContaAPagarRepository : BaseRepository<ContaAPagar>, IContaAPagarRepository
    {
        public ContaAPagarRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
