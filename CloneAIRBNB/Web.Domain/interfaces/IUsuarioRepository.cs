using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Domain.entities;

namespace Web.Domain.interfaces
{
    public interface IUsuarioRepository
    {
        IQueryable<Usuario> ListarUsuarios();

        Usuario BuscarUsuarioCpf(string cpf);
        
        Usuario BuscarUsuarioId(int id);

        Usuario Save(Usuario user);
    }
}