using System;

namespace ControleFinanceiro.Domain.Dtos
{
    public class ContaAPagarInsertDto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}
