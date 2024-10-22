namespace StockWise.Domain.Models
{
    public class SaidaProduto
    {
        public int IdSaidaProduto { get; set; }
        public int OrdemCompraId { get; set; }
        public OrdemCompra OrdemCompra { get; set; }
        public int Quantidade { get; set; }
        public string Usuario { get; set; }
        public string DepartamentoSolicitante { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
