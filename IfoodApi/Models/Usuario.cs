using System.ComponentModel.DataAnnotations;

namespace IfoodApi.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Nome { get; set; }
    }
}
