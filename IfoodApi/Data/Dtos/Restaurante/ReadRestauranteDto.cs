using System.ComponentModel.DataAnnotations;
using IfoodApi.Models;

namespace IfoodApi.Data.Dtos.Restaurante
{
    public class ReadRestauranteDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}