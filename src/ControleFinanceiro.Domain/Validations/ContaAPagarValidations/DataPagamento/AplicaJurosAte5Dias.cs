using ControleFinanceiro.Domain.Models;

namespace ControleFinanceiro.Domain.Validations.ContaAPagarValidations.DataPagamento
{
    public class AplicaJurosAte5Dias : IAplicaJuros
    {
        public IAplicaJuros Proximo { get; set; }

        public void Calcula(ContaAPagar contaAPagar)
        {
            var difDate = (contaAPagar.DataPagamento - contaAPagar.DataVencimento).Days;
            if (difDate > 3 && difDate <= 5)
            {
                contaAPagar.QtdDiasAtraso = difDate;
                contaAPagar.Juro = difDate * 0.002;
                contaAPagar.Multa = 0.03;
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
