using System.ComponentModel.DataAnnotations;
using IfoodApi.Models;

namespace IfoodApi.Data.Dtos.Restaurante
{
    public class CreateRestauranteDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public Address Address { get; set; }

    }
}