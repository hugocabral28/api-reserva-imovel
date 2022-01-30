using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Domain.entities;
using Web.Services.interfaces;
using Web.Services.services;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("imoveis")]
    public class ImovelController : ControllerBase
    {
        private readonly IImovelService _imovelService;

        public ImovelController(IImovelService imovelService)
        {
            _imovelService = imovelService;
        }

        [HttpPost]
        public IActionResult CadastrarImovel([FromBody] Imovel imovel)
        {
            var imovelCadastrado =  _imovelService.CadastrarImovel(imovel);
            return Ok(imovelCadastrado);
        }

        [HttpGet]
        public IActionResult ListarImovel()
        {
            var imovel = _imovelService.ListarImovel();
            return Ok(imovel);
        }

        [HttpGet("proprietarios/{idProprietario}")]
        public IActionResult ListarImovelProprietario([FromRoute] int idProprietario)
        {
            var imovelProprietario = _imovelService.ListarImovelProprietario(idProprietario);
            return Ok(imovelProprietario);
        }

        [HttpGet("{idImovel}")]
        public IActionResult BuscarImovelId([FromRoute] int idImovel)
        {
            var imovel = _imovelService.ListarImovelProprietario(idImovel);
            return Ok(imovel);
        }

        [HttpDelete("{idImovel}")]
        public IActionResult ExcluirImovel()
        {
            return Ok();
        }

    }
}