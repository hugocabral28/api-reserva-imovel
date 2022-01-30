using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Domain.entities;
using Web.Domain.interfaces;
using Web.Services.interfaces;

namespace Web.Services.services
{
    public class ImovelService : IImovelService
    {
        private readonly IImovelRepository _imovelRepository;
        public Imovel BuscarImovelId(int id)
        {
            return _imovelRepository.BuscarImovelId(id);
        }

        public IQueryable<Imovel> ListarImovel()
        {
            return _imovelRepository.ListarImovel();
        }

        public Imovel ListarImovelProprietario(int id)
        {
            return _imovelRepository.ListarImovelProprietario(id);
        }

        public Imovel CadastrarImovel(Imovel imovel)
        {
            return _imovelRepository.Save(imovel);
        }
    }
}