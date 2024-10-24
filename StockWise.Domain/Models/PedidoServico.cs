namespace StockWise.Domain.Models
{
    public class PedidoServico : Pedido
    {
        public int IdPedidoServico { get; set; }
        public int IdServico { get; set; }
        public Servico Servico { get; set; }
        public int IdFornecedor { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public string Observacao { get; set; }
    }
}
