
using System;
using ControleFinanceiro.Domain.Models;

namespace ControleFinanceiro.Domain.Validations.ContaAPagarValidations.DataPagamento
{
    public class AplicaJurosAte3dias : IAplicaJuros
    {
        public IAplicaJuros Proximo { get; set; }

        public void Calcula(ContaAPagar contaAPagar)
        {
            var difDate = (contaAPagar.DataPagamento - contaAPagar.DataVencimento).Days;
            if (difDate <= 3)
            {
                var multa = contaAPagar.ValorOriginal * 0.02;
                var juros = contaAPagar.ValorOriginal * (difDate * 0.001);
                contaAPagar.ValorCorrigido = contaAPagar.ValorOriginal + multa + juros;
                contaAPagar.QtdDiasAtraso = difDate;
                return;
            }

            if (Proximo != null)
                Proximo.Calcula(contaAPagar);
        }
    }
}