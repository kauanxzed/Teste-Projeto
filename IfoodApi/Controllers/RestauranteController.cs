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
        public IActionResult CadastraRestaurante([FromBody] CreateRestauranteDto restauranteDto)
        {
            ReadRestauranteDto readtDto = _restauranteService.CadastraRestaurante(restauranteDto);
            return CreatedAtAction(nameof(RecuperaRestaurantePorId), new { Id = readtDto.Id }, readtDto);
        }


        [HttpGet("{id}")]
        public IActionResult RecuperaRestaurantePorId(int id)
        {
            ReadRestauranteDto readDto = _restauranteService.RecuperaRestaurantePorId(id);
            if (readDto == null) return NotFound();
            return Ok(readDto);
        }
    }
}