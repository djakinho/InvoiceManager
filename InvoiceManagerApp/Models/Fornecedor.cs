using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Models
{
    public class Fornecedor : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome precisa ser preenchido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Vertical precisa ser selecionado")]
        public Vertical Vertical { get; set; }
        [Required(ErrorMessage = "O campo do Link para Login precisa ser preenchido")]
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
