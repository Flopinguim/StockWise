namespace StockWise.Domain.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdDepartamento { get; set; }
        public Departamento Departamento { get; set; }
        public int IdUsuarioSolicitante { get; set; }
        public Usuario UsuarioSolicitante { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdOrdemCompra { get; set; }
        public OrdemCompra OrdemCompra { get; set; }
    }
}
