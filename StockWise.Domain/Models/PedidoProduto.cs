namespace StockWise.Domain.Models
{
    public class PedidoProduto : Pedido
    {
        public int IdPedidoProduto { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
