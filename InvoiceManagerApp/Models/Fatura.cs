using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Models
{
    public class Fatura : IEntity
    {
        public int Id { get; set; }
        public DateTime DtEmissao { get; set; }
        public DateTime DtVencimento { get; set; }
        public decimal Total { get; set; }
        public decimal ValorPago { get; set; }
        public int IdFornecedor { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
    }
}
