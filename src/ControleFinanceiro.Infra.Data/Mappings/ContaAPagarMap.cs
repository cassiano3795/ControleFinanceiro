using ControleFinanceiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFinanceiro.Infra.Data.Mappings
{
    public class ContaAPagarMap : IEntityTypeConfiguration<ContaAPagar>
    {
        public void Configure(EntityTypeBuilder<ContaAPagar> builder)
        {
            builder.ToTable("conta_a_pagar");

            builder.Property(p => p.Nome)
                .HasColumnName("nome")
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(p => p.ValorOriginal)
                .HasColumnName("valor_original")
                .HasColumnType("decimal(13,2)")
                .IsRequired();

                builder.Property(p => p.ValorCorrigido)
                .HasColumnName("valor_corrigido")
                .HasColumnType("decimal(13,9)")
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(p => p.DataVencimento)
                .HasColumnName("data_vencimento")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.DataPagamento)
                .HasColumnName("data_pagamento")
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.QtdDiasAtraso)
                .HasColumnName("qtd_dias_atraso")
                .HasColumnType("int")
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(p => p.Multa)
                .HasColumnName("multa")
                .HasColumnType("float")
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(p => p.Juro)
                .HasColumnName("juro")
                .HasColumnType("float")
                .HasDefaultValue(0)
                .IsRequired();
        }
    }
}
