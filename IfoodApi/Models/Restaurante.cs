using System.ComponentModel.DataAnnotations;

namespace IfoodApi.Models
{
    public class Restaurante
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public Address Address { get; set; }
        [Required]
        public int AddressId { get; set; }

    }
}