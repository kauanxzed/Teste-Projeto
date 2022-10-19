using System.ComponentModel.DataAnnotations;
using IfoodApi.Models;

namespace IfoodApi.Data.Dtos.Restaurante
{
    public class ReadRestauranteDto
    {
        [Required]
        public string Nome { get; set; }
    }
}