using System.ComponentModel.DataAnnotations;
using IfoodApi.Models;

namespace IfoodApi.Data.Dtos.RestauranteDto
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