using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.API.models.request;
using Web.API.models.response;
using Web.Domain.entities;
using Web.Services.interfaces;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult CadastrarUsuario([FromBody] Usuario usuarioResquest)
        {
            var saveUser = _usuarioService.CadastrarUsuario(usuarioResquest);

            var userResponse = new UsuarioResponse();

            userResponse.Imagem = saveUser.Imagem;
            userResponse.Nome = saveUser.Nome;
            userResponse.Email = saveUser.Email;
            userResponse.DataNascimento = saveUser.DataNascimento;
            userResponse.Endereco = saveUser.Endereco;

            return Ok(userResponse);
        }

        [HttpGet]
        public IActionResult ListarUsuarios()
        {
            var users = _usuarioService.ListarUsuarios();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarUsuarioId([FromRoute] int id)
        {
            var user = _usuarioService.BuscarUsuarioId(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("cpf/{cpf}")]
        public IActionResult BuscarUsuarioCpf([FromRoute] string cpf)
        {
            var user = _usuarioService.BuscarUsuarioCpf(cpf);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult AlterarUsuario([FromRoute] int id, UsuarioRequest usuarioRequest)
        {
            return Ok();
        }


    }
}