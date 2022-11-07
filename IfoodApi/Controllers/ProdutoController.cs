using IfoodApi.Services;
using Microsoft.AspNetCore.Mvc;
using IfoodApi.Data.Dtos.Produto;
using IfoodApi.Data.Dtos.Address;

namespace IfoodApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private ProdutoService _produtoService;

        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost("/produto")]
        public IActionResult AddProduto([FromBody] CreateProdutoDto createDto)
        {
            ReadProdutoDto readDto = _produtoService.AddProduto(createDto);
            return CreatedAtAction(nameof(RecuperaProdutoPorId), new { id = readDto.Id }, readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaProdutoPorId(int id)
        {
            ReadProdutoDto readDto = _produtoService.RecuperaProdutoPorId(id);
            if(readDto == null) return NotFound();
            return Ok(readDto);
        }

    }
}
