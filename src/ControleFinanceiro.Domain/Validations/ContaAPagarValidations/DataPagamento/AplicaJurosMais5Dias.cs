using ControleFinanceiro.Domain.Models;

namespace ControleFinanceiro.Domain.Validations.ContaAPagarValidations.DataPagamento
{
    public class AplicaJurosMais5Dias : IAplicaJuros
    {
        public IAplicaJuros Proximo { get; set; }

        public void Calcula(ContaAPagar contaAPagar)
        {
            var difDate = (contaAPagar.DataPagamento - contaAPagar.DataVencimento).Days;
            if (difDate > 5)
            {
                contaAPagar.QtdDiasAtraso = difDate;
                contaAPagar.Juro = difDate * 0.003;
                contaAPagar.Multa = 0.05;
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
