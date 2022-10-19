using FluentResults;
using IfoodApi.Data.Dtos.Restaurante;
using Microsoft.AspNetCore.Mvc;
using IfoodApi.Services;

namespace IfoodApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private RestauranteService _restauranteService;
        
        public RestauranteController(RestauranteService restauranteService)
        {
            _restauranteService = restauranteService;
        }

        [HttpPost("/cadastro")]
        public IActionResult CadastraRestaurante(CreateRestauranteDto restauranteDto)
        {
            var resultado = _restauranteService.CadastraRestaurante(restauranteDto);
            if(resultado.IsFailed) return StatusCode(500);
            return Ok();
        }
    }
}