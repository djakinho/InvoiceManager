﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Vertical Vertical { get; set; }
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
