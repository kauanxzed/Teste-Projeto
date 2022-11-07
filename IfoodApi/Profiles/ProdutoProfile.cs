using AutoMapper;
using IfoodApi.Data.Dtos.Produto;
using IfoodApi.Models;

namespace IfoodApi.Profiles
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<CreateProdutoDto, Produto>();
            CreateMap<Produto, ReadProdutoDto>();
        }
    }
}
