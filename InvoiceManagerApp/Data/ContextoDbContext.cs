using InvoiceManagerApp.Data.Map;
using InvoiceManagerApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Data
{
    public class ContextoDbContext : DbContext
    {
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Fatura> Fatura { get; set; }

        public ContextoDbContext(DbContextOptions<ContextoDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new FaturaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
