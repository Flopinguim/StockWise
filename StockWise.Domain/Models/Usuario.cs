﻿namespace StockWise.Domain.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
    }
}
