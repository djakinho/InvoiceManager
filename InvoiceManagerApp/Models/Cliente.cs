using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string BancoNome { get; set; }
        public string BancoAgencia { get; set; }
        public string BancoConta { get; set; }
        public List<Fatura> Faturas { get; set; }
    }
}
