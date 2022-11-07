using IfoodApi.Models;

namespace IfoodApi.Data.Dtos.Produto
{
    public class ReadProdutoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public Restaurante Restaurante { get; set; }
    }
}
