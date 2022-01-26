using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web.Domain.entities;

namespace Web.Infra.mapper
{
    public static class UsuarioMapper
    {
        public static void AddUser(this ModelBuilder modelBuilder)
        {
            var builderUser = modelBuilder.Entity<Usuario>();
            builderUser.ToTable("Usuario");

            builderUser.HasKey(user => user.Id);

            builderUser
                .Property(user => user.Id)
                .HasColumnName("Id");

            builderUser
                .Property(user => user.Imagem)
                .HasColumnName("Imagem");

            builderUser
                .Property(user => user.Nome)
                .HasColumnName("Nome");

            builderUser
                .Property(user => user.Email)
                .HasColumnName("Email");

            builderUser
                .Property(user => user.Senha)
                .HasColumnName("Senha");

            builderUser
                .Property(user => user.CPF)
                .HasColumnName("Cpf");

            builderUser
                .Property(user => user.DataNascimento)
                .HasColumnName("DataNascimento");

            builderUser
                .Property(user => user.IdEndereco)
                .HasColumnName("IdEndereco");

            builderUser
                .HasOne<Endereco>(user => user.Endereco)
                .WithOne()
                .HasForeignKey<Usuario>(user => user.IdEndereco);
        }
    }
}