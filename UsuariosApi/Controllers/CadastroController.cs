using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos.Usuario;
using UsuariosApi.Data.Requests;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        private CadastroService _cadastroService;

        public CadastroController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost("/cadastro")]
        public IActionResult CadastraUsuario(CreateUsuarioDto createDto)
        {
            var resultado = _cadastroService.CadastraUsuario(createDto);
            if (resultado.Result.IsFailed) return StatusCode(500);
            return Ok(resultado.Result.Successes.FirstOrDefault());
        }

        [HttpGet("/ativa")]
        public IActionResult AtivaContaUsuario([FromQuery] AtivaContaRequest request)
        {
            Result resultado = _cadastroService.AtivaContaUsuario(request);
            if (resultado.IsFailed) return StatusCode(500);
            return Ok(resultado.Successes.FirstOrDefault());
        }

    }
}
