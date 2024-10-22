namespace StockWise.Domain.Models
{
    public class OrdemCompra
    {
        public int IdOrdemCompra { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
