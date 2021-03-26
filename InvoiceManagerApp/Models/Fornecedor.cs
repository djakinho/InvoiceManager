using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Models
{
    public class Fornecedor : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Vertical Vertical { get; set; }
        [DisplayName("Link para Login")]
        public string LinkLogin { get; set; }
        public List<Fatura> Faturas { get; set; }
    }

    public enum Vertical
    {
        Energia = 1,
        Agua = 2,
        Telecom = 3
    }
}
