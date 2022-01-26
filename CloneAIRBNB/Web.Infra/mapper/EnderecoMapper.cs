using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web.Domain.entities;

namespace Web.Infra.mapper
{
    public static class EnderecoMapper
    {
        public static void AddAddress(this ModelBuilder modelBuilder)
        {
            var buildAddress = modelBuilder.Entity<Endereco>();

            buildAddress.ToTable("Endereco");

            buildAddress.HasKey(address => address.Id);

            buildAddress
                .Property(address => address.Id)
                .HasColumnName("Id");

            buildAddress
                .Property(address => address.Cep)
                .HasColumnName("Cep");

            buildAddress
                .Property(address => address.Logradouro)
                .HasColumnName("Logradouro");

            buildAddress
                .Property(address => address.Numero)
                .HasColumnName("Numero");

            buildAddress
                .Property(address => address.Complemento)
                .HasColumnName("Complemento");

            buildAddress
                .Property(address => address.Bairro)
                .HasColumnName("Bairro");

            buildAddress
                .Property(address => address.Cidade)
                .HasColumnName("Cidade");

            buildAddress
                .Property(address => address.Estado)
                .HasColumnName("Estado");

        }
    }
}