namespace IfoodApi.Data.Dtos.Produto
{
    public class CreateProdutoDto
    {
        public int RestauranteId { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public string Foto { get; set; }
        public string Descricao { get; set; }
    }
}
