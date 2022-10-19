using FluentResults;
using AutoMapper;
using IfoodApi.Data.Dtos.Restaurante;
using IfoodApi.Data;
using IfoodApi.Models;

namespace IfoodApi.Services
{
    public class RestauranteService
    {
        private IMapper _mapper;
        private AppDbContext _context;
        public RestauranteService(IMapper mapper, AppDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public Result CadastraRestaurante(CreateRestauranteDto dto)
        {
            Restaurante restaurante = _mapper.Map<Restaurante>(dto);
            _context.Restaurantes.Add(restaurante);
            _context.SaveChanges();
            var restauranteCriado = _mapper.Map<ReadRestauranteDto>(restaurante).ToResult();
            if(restauranteCriado.IsFailed)
            {
                return Result.Fail("não cadastrou o restaurante");
            }
            return Result.Ok();
        }
    }
}