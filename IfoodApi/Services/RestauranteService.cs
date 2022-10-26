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

        public ReadRestauranteDto CadastraRestaurante(CreateRestauranteDto dto)
        {

            Restaurante restaurante = _mapper.Map<Restaurante>(dto);
            _context.Restaurantes.Add(restaurante);
            _context.SaveChanges();
            return _mapper.Map<ReadRestauranteDto>(restaurante);
        }

        public ReadRestauranteDto RecuperaRestaurantePorId(int id)
        {
            Restaurante restaurante = _context.Restaurantes.FirstOrDefault(restaurante => restaurante.Id == id);
            if (restaurante != null)
            {
                return _mapper.Map<ReadRestauranteDto>(restaurante);
            }
            return null;
        }
    }
}