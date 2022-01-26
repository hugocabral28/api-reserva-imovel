using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.API.models.request;
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
        public IActionResult CadastrarUsuario([FromBody] Usuario userResquest)
        {
            var saveUser = _usuarioService.CadastrarUsuario(userResquest);

            return Ok(saveUser);
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
        public IActionResult AlterarUsuario([FromRoute] int id, UserRequest userRequest)
        {
            return Ok();
        }


    }
}