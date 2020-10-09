using System;

namespace ControleFinanceiro.Domain.Models
{
    public class ContaAPagar : BaseModel
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public int QtdDiasAtraso { get; set; }
        public double Multa { get; set; }
        public double Juro { get; set; }
    }
}
