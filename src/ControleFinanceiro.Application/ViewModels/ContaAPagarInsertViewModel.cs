using System;
using System.ComponentModel.DataAnnotations;
namespace ControleFinanceiro.Application.ViewModels
{
    public class ContaAPagarInsertViewModel
    {
        [Required(ErrorMessage = "O nome deve ser preenchido")]
        [MaxLength(200, ErrorMessage = "O nome deve ter no máximo 200 caracteres")]
        public string Nome { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor do pagamento precisa ser maior que 0")]
        public double Valor { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataVencimento { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataPagamento { get; set; }
    }
}
