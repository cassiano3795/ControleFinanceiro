using ControleFinanceiro.Domain.Models;

namespace ControleFinanceiro.Domain.Validations.ContaAPagarValidations.DataPagamento
{
    public interface IAplicaJuros
    {
        IAplicaJuros Proximo { get; set; }
        void Calcula(ContaAPagar contaAPagar);
    }
}
