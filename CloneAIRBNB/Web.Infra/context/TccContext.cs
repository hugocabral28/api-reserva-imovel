using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web.Domain.entities;
using Web.Infra.mapper;

namespace Web.Infra.context
{
    public class TccContext : DbContext
    {

        public TccContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Usuario> Users { get; set; }
        public DbSet<Endereco> Addresses { get; set; }
        public DbSet<Imovel> Imovel { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>();
            modelBuilder.AddUser();

            modelBuilder.Entity<Endereco>();
            modelBuilder.AddAddress();

            modelBuilder.Entity<Imovel>();
            modelBuilder.AddImovel();

        }
    }
}