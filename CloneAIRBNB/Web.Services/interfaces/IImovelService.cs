using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Domain.entities;

namespace Web.Services.interfaces
{
    public interface IImovelService
    {
        IQueryable<Imovel> ListarImovel();

        Imovel BuscarImovelId(int id);

        Imovel ListarImovelProprietario(int id);

        Imovel CadastrarImovel(Imovel imovel);
    }
}