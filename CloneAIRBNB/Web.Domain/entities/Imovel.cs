using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Domain.entities.enuns;

namespace Web.Domain.entities
{
    public class Imovel
    {

        public int Id { get; set; }
        public string Identificacao { get; set; }
        public TipoImovel TipoImovel { get; set; }
        public int ? IdEndereco { get; set; }
        public Endereco Endereco { get; set; }
        public int ? IdProprietario { get; set; }
        public Usuario Proprietario { get; set; }
        public List<CaracteristicaImovel> Caracteristicas { get; set; }
        public Boolean Deleted { get; set; }


        public Imovel()
        {
        }

        public Imovel(int id, string identificacao, TipoImovel tipoImovel, Endereco endereco, Usuario proprietario, List<CaracteristicaImovel> caracteristicas, bool deleted)
        {
            Id = id;
            Identificacao = identificacao;
            TipoImovel = tipoImovel;
            Endereco = endereco;
            Proprietario = proprietario;
            Caracteristicas = caracteristicas;
            Deleted = deleted;
        }
    }
}