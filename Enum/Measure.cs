using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBudget.Enum
{
    internal enum Measure
    {
        [Description("Kilo")]
        Kg = 0,
        [Description("Gramas")]
        g = 1,
        [Description("Metros")]
        M = 2,
        [Description("Unidades")]
        Un = 3,
        [Description("Conjunto")]
        Cj = 4,
        [Description("Desconhecido")]
        Unknown = 5
    }
}
