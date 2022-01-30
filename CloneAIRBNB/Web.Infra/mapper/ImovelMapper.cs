using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web.Domain.entities;

namespace Web.Infra.mapper
{
    public static class ImovelMapper
    {
        public static void AddImovel(this ModelBuilder modelBuilder)
        {
            var builderImovel = modelBuilder.Entity<Imovel>();
            builderImovel.ToTable("Imovel");

            builderImovel.HasKey(imovel => imovel.Id);

            builderImovel
                .Property(imovel => imovel.Id)
                .HasColumnName("Id");

            builderImovel
                .Property(imovel => imovel.IdEndereco)
                .HasColumnName("IdEndereco");

            builderImovel
                .Property(imovel => imovel.Identificacao)
                .HasColumnName("Identificacao");

            builderImovel
                .Property(imovel => imovel.IdProprietario)
                .HasColumnName("IdProprietario");

            builderImovel
                .Property(imovel => imovel.TipoImovel)
                .HasColumnName("TipoImovel");

            builderImovel
                .Property(imovel => imovel.Deleted)
                .HasColumnName("Deleted");

            // builderImovel
            //     .HasMany<CaracteristicaImovel>(imovel => imovel.Caracteristicas)
            //     .WithMany("CaracteristicaImovel")
            //     .HasForeignKey<Imovel>(Imovel => Imovel.Caracteristicas);

            builderImovel
                .HasOne<Endereco>(imovel => imovel.Endereco)
                .WithOne()
                .HasForeignKey<Imovel>(Imovel => Imovel.IdEndereco);

            builderImovel
             .HasOne<Usuario>(imovel => imovel.Proprietario)
             .WithOne()
             .HasForeignKey<Imovel>(Imovel => Imovel.IdProprietario);


        }
    }
}