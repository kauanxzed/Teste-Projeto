using AutoMapper;
using IfoodApi.Models;
using IfoodApi.Data.Dtos.Restaurante;

namespace IfoodApi.Profiles
{
    public class RestauranteProfile : Profile
    {
        public RestauranteProfile()
        {
            CreateMap<CreateRestauranteDto, Restaurante>();
            CreateMap<Restaurante, ReadRestauranteDto>();
        }
    }
}