using AutoMapper;
using IfoodApi.Data.Dtos.Address;
using IfoodApi.Models;

namespace IfoodApi.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<CreateAddressDto, Address>();
            CreateMap<Address, ReadAddressDto>();
        }
    }
}
