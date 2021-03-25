using InvoiceManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Data.Interface
{
    public interface IBaseRepository<T> where T : class, IEntity
    {
        void Adicionar(T entity);
        void Editar(T entity);
        T Selecionar(int id);
        List<T> SelecionarTudo();
        void Apagar(int id);
        void Dispose();
    }
}
