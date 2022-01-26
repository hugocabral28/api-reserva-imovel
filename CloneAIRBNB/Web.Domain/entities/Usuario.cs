using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Domain.entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Imagem { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
        public int ? IdEndereco { get; set; }
        public Endereco Endereco { get; set; }

        public Usuario()
        {

        }

        public Usuario(int id, string imagem, string name, string email, string password, string cpf, string dataNascimento, Endereco endereco)
        {
            Id = id;
            Imagem = imagem;
            Nome = name;
            Email = email;
            Senha = password;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }
    }
}