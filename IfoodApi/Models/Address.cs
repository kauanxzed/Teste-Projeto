using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace IfoodApi.Models
{
    public class Address
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public int Numero { get; set; }
        [JsonIgnore]
        public virtual Restaurante Restaurante { get; set; }
    }
}