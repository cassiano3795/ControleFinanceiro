
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
            if (difDate > 0 && difDate <= 3)
            {
                contaAPagar.QtdDiasAtraso = difDate;
                contaAPagar.Juro = difDate * 0.001;
                contaAPagar.Multa = 0.02;
                var multa = contaAPagar.ValorOriginal * contaAPagar.Multa;
                var juros = contaAPagar.ValorOriginal * contaAPagar.Juro;
                contaAPagar.ValorCorrigido += multa + juros;
                return;
            }

            if (Proximo != null)
                Proximo.Calcula(contaAPagar);
        }
    }
}
