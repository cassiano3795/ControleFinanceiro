using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiro.Domain.Models
{
    public class BaseModel
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("data_criacao")]
        public DateTime DataCriação { get; set; }

        [Column("data_update")]
        public DateTime DataUpdate { get; set; }
    }
}
