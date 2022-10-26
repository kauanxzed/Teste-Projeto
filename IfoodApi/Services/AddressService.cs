using AutoMapper;
using IfoodApi.Data;
using IfoodApi.Data.Dtos.Address;
using IfoodApi.Models;

namespace IfoodApi.Services
{
    public class AddressService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public AddressService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadAddressDto AddAddress(CreateAddressDto addressDto)
        {
            Address address = _mapper.Map<Address>(addressDto);
            _context.Address.Add(address);
            _context.SaveChanges();
            return _mapper.Map<ReadAddressDto>(address);
        }

        public ReadAddressDto RecuperarAddressPorId(int id)
        {
            Address address = _context.Address.FirstOrDefault(address => address.Id == id);
            if (address != null)
            {
                ReadAddressDto addressDto = _mapper.Map<ReadAddressDto>(address);
                return addressDto;
            }
            return null;
        }
    }
}
