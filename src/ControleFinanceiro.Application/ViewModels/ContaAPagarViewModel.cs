using System;

namespace ControleFinanceiro.Application.ViewModels
{
    public class ContaAPagarViewModel
    {
        public string Nome { get; set; }
        public double ValorOriginal { get; set; }
        public double ValorCorrigido { get; set; }
        public DateTime DataPagamento { get; set; }
        public int QtdDiasAtraso { get; set; }
    }
}
