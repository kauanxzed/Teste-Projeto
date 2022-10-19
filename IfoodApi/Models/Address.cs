using System.ComponentModel.DataAnnotations;
namespace IfoodApi.Models
{
    public class Address
    {
        [Required]
        public string Rua { get; set; }
    }
}