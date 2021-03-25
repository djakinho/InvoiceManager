using InvoiceManagerApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceManagerApp.Data.Map
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(x => x.Rg)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.BancoNome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.BancoAgencia)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.BancoConta)
                .HasColumnType("varchar(50)")
                .IsRequired();


        }
    }
}
