using System.ComponentModel.DataAnnotations;

namespace IfoodApi.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public float Preco { get; set; }
        public virtual Restaurante Restaurante { get; set; }
        public int RestauranteId { get; set; }
        public string Foto { get; set; }
        public string Descricao { get; set; }
    }
}