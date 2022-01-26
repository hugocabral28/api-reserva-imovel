using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Domain.entities;
using Web.Domain.interfaces;
using Web.Services.interfaces;

namespace Web.Services.services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario CadastrarUsuario(Usuario user)
        {
            ImagemAvatar img = new ImagemAvatar();
            user.Imagem = img.Img;
            return _usuarioRepository.Save(user);
        }

        public IQueryable<Usuario> ListarUsuarios()
        {
            return _usuarioRepository.ListarUsuarios();
        }

        public Usuario BuscarUsuarioCpf(string cpf)
        {
            return _usuarioRepository.BuscarUsuarioCpf(cpf);
        }

        public Usuario BuscarUsuarioId(int id)
        {
            return _usuarioRepository.BuscarUsuarioId(id);
        }

    }
}