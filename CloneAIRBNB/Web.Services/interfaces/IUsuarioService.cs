using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Domain.entities;

namespace Web.Services.interfaces
{
    public interface IUsuarioService
    {
        IQueryable<Usuario> ListarUsuarios();

        Usuario BuscarUsuarioCpf(string cpf);

        Usuario BuscarUsuarioId(int id);

        Usuario CadastrarUsuario(Usuario user);


    }
}