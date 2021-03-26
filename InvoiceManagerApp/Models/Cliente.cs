using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Models
{
    public class Cliente : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O campo Nome precisa ser preenchido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo RG precisa ser preenchido")]
        public string Rg { get; set; }
        [Required(ErrorMessage = "O Nome do Banco precisa ser preenchido")]
        public string BancoNome { get; set; }
        [Required(ErrorMessage = "O campo da Agência Bancária precisa ser preenchido")]
        public string BancoAgencia { get; set; }
        [Required(ErrorMessage = "O Número da Conta precisa ser preenchido")]
        public string BancoConta { get; set; }
        public List<Fatura> Faturas { get; set; }
    }
}
