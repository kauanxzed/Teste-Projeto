using AutoMapper;
using IfoodApi.Data;
using IfoodApi.Data.Dtos.Produto;
using IfoodApi.Models;

namespace IfoodApi.Services
{
    public class ProdutoService
    {
        private AppDbContext _dbContext;
        private IMapper _mapper;

        public ProdutoService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public ReadProdutoDto AddProduto(CreateProdutoDto createDto)
        {
            Produto produto = _mapper.Map<Produto>(createDto);
            _dbContext.Add(produto);
            _dbContext.SaveChanges();
            return _mapper.Map<ReadProdutoDto>(produto);
        }

        internal ReadProdutoDto RecuperaProdutoPorId(int id)
        {
            Produto produto = _dbContext.Produtos.FirstOrDefault(produto => produto.Id == id);
            if(produto != null)
            {
                ReadProdutoDto readDto = _mapper.Map<ReadProdutoDto>(produto);
                return readDto;
            }
            return null;
        }
    }
}
