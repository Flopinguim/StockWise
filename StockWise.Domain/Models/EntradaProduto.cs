namespace StockWise.Domain.Models
{
    public class EntradaProduto
    {
        public int IdEntradaProduto { get; set; }
        public int OrdemCompraId { get; set; }
        public OrdemCompra OrdemCompra { get; set; }
        public string NotaFiscal { get; set; }
        public int Quantidade { get; set; }
        public string Deposito { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
