using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // TODO: AQUI AS CONFIGURAÇÕES

            base.OnModelCreating(modelBuilder);
        }
    }
}
