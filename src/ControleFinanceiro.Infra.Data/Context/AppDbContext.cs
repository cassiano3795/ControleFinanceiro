using ControleFinanceiro.Domain.Models;
using ControleFinanceiro.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ContaAPagar> ContasAPagar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContaAPagarMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
