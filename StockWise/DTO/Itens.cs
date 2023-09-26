using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public  class Itens
    {
        //Declaração dos Atributos de Classe: Pessoa 
        public int Codigo { get; set; }
        public string Nome { get; set;}
        public string Descricao { get; set;}
        public DateTime DataAquisicao { get; set; }
        public string NumeroDeSerie { get; set; }
        public string VidaUtil { get;set; }
        public int IdadeItem { get; set; }
        public double ValorDeCompra { get; set; }
        public string Categoria { get; set; }
        public string Setores { get; set; }
        public bool Inativo { get; set; }

    }
}
