using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBudget.Enums
{
    internal enum Measure
    {
        [Description("Desconhecido")]
        Unknown = 0,
        [Description("Gramas")]
        g = 1,
        [Description("Metros")]
        M = 2,
        [Description("Unidades")]
        Un = 3,
        [Description("Conjunto")]
        Cj = 4,
        [Description("Kilogramas")]
        Kg = 5
    }
}
