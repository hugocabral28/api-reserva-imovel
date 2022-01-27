using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Domain.entities;

namespace Web.API.models.response
{
    public class UsuarioResponse
    {

        public string Imagem { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        
        public UsuarioResponse()
        {
        }
        public UsuarioResponse(string imagem, string nome, string email, string senha, string cPF, string dataNascimento, Endereco endereco)
        {
            Imagem = imagem;
            Nome = nome;
            Email = email;
            Senha = senha;
            CPF = cPF;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }

    }
}