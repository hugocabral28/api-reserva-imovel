using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web.Domain.entities;
using Web.Domain.interfaces;
using Web.Infra.context;

namespace Web.Infra.repository
{
    public class ImovelRepository : IImovelRepository
    {
        private readonly TccContext _tccContext;

        public ImovelRepository(TccContext tccContext)
        {
            _tccContext = tccContext;
        }

        public Imovel BuscarImovelId(int id)
        {
            return _tccContext.Imovel.Include("Usuario").Include("Endereco").Where(imovel => imovel.Id == id).FirstOrDefault();
        }

        public IQueryable<Imovel> ListarImovel()
        {
            return _tccContext.Imovel.Include("Usuario").Include("Endereco");
        }

        public Imovel ListarImovelProprietario(int id)
        {
            return _tccContext.Imovel.Include("Usuario").Include("Endereco").Where(imovel => imovel.IdProprietario == id).FirstOrDefault();
        }

        public Imovel Save(Imovel imovel)
        {
            _tccContext.Imovel.Add(imovel);
            _tccContext.SaveChanges();
            return imovel;
        }
    }
}