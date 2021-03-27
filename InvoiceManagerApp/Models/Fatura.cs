using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Models
{
    public class Fatura : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Data de Emissão precisa ser preenchido")]
        public DateTime DtEmissao { get; set; }
        [Required(ErrorMessage = "O campo Data de Vencimento precisa ser preenchido")]
        public DateTime DtVencimento { get; set; }
        [Required(ErrorMessage = "O valor Total precisa ser preenchido")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor Total da fatura precisa ser igual ou maior que $0.01")]
        public decimal Total { get; set; }
        [Required(ErrorMessage = "O Valor Pago precisa ser preenchido")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O Valor Pago precisa ser igual ou maior que $0.01")]
        public decimal ValorPago { get; set; }
        [Required(ErrorMessage = "Um Fornecedor precisa ser escolhido")]
        public int IdFornecedor { get; set; }
        public Fornecedor Fornecedor { get; set; }
        [Required(ErrorMessage = "Um Cliente precisa ser escolhido")]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }

    }
}
