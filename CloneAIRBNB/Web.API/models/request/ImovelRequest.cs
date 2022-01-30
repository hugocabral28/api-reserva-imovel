using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Domain.entities;
using Web.Domain.entities.enuns;

namespace Web.API.models.request
{
    public class ImovelRequest
    {

        public string Identificacao { get; set; }
        public TipoImovel TipoImovel { get; set; }
        public Endereco Endereco { get; set; }
        public int IdProprietario { get; set; }
        public List<CaracteristicaImovel> Caracteristicas { get; set; }

        
        public ImovelRequest()
        {
        }
        public ImovelRequest(string identificacao, TipoImovel tipoImovel, Endereco endereco, int idProprietario, List<CaracteristicaImovel> caracteristicas)
        {
            Identificacao = identificacao;
            TipoImovel = tipoImovel;
            Endereco = endereco;
            IdProprietario = idProprietario;
            Caracteristicas = caracteristicas;
        }

    }
}