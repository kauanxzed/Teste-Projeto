using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IfoodApi.Services;
using IfoodApi.Data.Dtos.Address;

namespace IfoodApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private AddressService _addresService;
        public AddressController(AddressService addressService)
        {
            _addresService = addressService;
        }

        [HttpPost("/address")]
        public IActionResult AddAddress([FromBody] CreateAddressDto addresDto)
        {
            ReadAddressDto readDto = _addresService.AddAddress(addresDto);
            return CreatedAtAction(nameof(RecuperaAddressPorId), new { id = readDto.Id }, readDto);
        }
        [HttpGet("{id}")]
        public IActionResult RecuperaAddressPorId(int id)
        {
            ReadAddressDto readDto = _addresService.RecuperarAddressPorId(id);
            if(readDto == null) return NotFound();
            return Ok(readDto);
        }
    }
}
