namespace ProdutosAPI.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 1; // Padrão de 1 item adicionado
    }
}
