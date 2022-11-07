using AutoMapper;
using IfoodApi.Models;
using IfoodApi.Data.Dtos.RestauranteDto;

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