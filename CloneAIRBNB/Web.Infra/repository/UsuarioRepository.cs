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
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly TccContext _context;
        public UsuarioRepository(TccContext context) => _context = context;

        public Usuario Save(Usuario user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public Usuario BuscarUsuarioCpf(string cpf)
        {
            return _context.Users.Include("Endereco").Where(u => u.CPF == cpf).FirstOrDefault();
        }

        public Usuario BuscarUsuarioId(int id)
        {
            return _context.Users.Include("Endereco").Where(u => u.Id == id).FirstOrDefault();
        }

        public IQueryable<Usuario> ListarUsuarios()
        {
            return _context.Users.Include("Endereco");
        }
    }
}