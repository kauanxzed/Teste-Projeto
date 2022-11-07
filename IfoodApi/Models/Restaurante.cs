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
        public virtual Address Address { get; set; }
        [Required]
        public int AddressId { get; set; }
        public virtual List<Produto> Produtos { get; set; }
    }
}