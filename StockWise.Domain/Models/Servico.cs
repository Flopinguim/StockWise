namespace StockWise.Domain.Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int PrazoEntrega { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
    }
}
