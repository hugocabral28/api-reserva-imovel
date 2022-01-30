using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Domain.entities;

namespace Web.Domain.interfaces
{
    public interface IImovelRepository
    {
        IQueryable<Imovel> ListarImovel();

        Imovel BuscarImovelId(int id);

        Imovel ListarImovelProprietario(int id);

        Imovel Save(Imovel imovel);


    }
}