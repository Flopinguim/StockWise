namespace StockWise.Domain.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
        public int UsuarioSolicitanteId { get; set; }
        public Usuario UsuarioSolicitante { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? OrdemCompraId { get; set; }
        public OrdemCompra OrdemCompra { get; set; }
    }
}
