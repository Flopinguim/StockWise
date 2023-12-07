using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public enum Setores
    {
        [Description("Comercial")]
        comercial = 1,
        [Description("Implantação")]
        implatacao = 2,
        [Description("Suporte Partner")]
        suporte_partner = 3,
        [Description("Suporte Final")]
        suporte_final = 4,
        [Description("Prime")]
        prime = 5,
        [Description("Financeiro")]
        financeiro = 6,
        [Description("Desevolvimento")]
        desenvolvimento = 7,
        [Description("Recursos Humanos")]
        recursos_humanos = 8,

    }
}
