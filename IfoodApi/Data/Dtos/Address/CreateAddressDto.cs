using System.ComponentModel.DataAnnotations;

namespace IfoodApi.Data.Dtos.Address
{
    public class CreateAddressDto
    {
        [Required]
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }

    }
}
