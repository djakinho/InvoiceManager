using InvoiceManagerApp.Data.Interface;
using InvoiceManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Data.Repository
{
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(Contexto contexto) : base(contexto)
        {

        }
    }
}
