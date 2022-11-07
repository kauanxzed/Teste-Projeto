using System.ComponentModel.DataAnnotations;

namespace IfoodApi.Data.Dtos.Address
{
    public class ReadAddressDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }

    }
}
