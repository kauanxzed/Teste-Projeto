using System.ComponentModel.DataAnnotations;

namespace IfoodApi.Models
{
    public class Restaurante
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public Address Address { get; set; }

    }
}