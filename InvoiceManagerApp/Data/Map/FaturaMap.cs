using InvoiceManagerApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Data.Map
{
    public class FaturaMap : IEntityTypeConfiguration<Fatura>
    {
        public void Configure(EntityTypeBuilder<Fatura> builder)
        {
            builder.ToTable("Fatura");

            builder.Property(x => x.DtEmissao)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.DtVencimento)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.Total)
                .HasColumnType("decimal")
                .IsRequired();

            builder.Property(x => x.ValorPago)
                .HasColumnType("decimal")
                .IsRequired();

            builder.HasOne(x => x.Fornecedor)
                .WithMany(x => x.Faturas)
                .HasForeignKey(x => x.IdFornecedor);

            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.Faturas)
                .HasForeignKey(x => x.IdCliente);
        }
    }
}
