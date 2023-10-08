using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBudget.Enums
{
    public enum City
    {
        [Description("Blumenau")]
        Blumenau = 0,
        [Description("Indaial")]
        Indaial = 1,
        [Description("Pomerode")]
        Pomerode = 2,
        [Description("Timbó")]
        Timbo = 3
    }
}
