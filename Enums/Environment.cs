using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBudget.Enums
{
    public enum Environment
    {
        [Description("Nenhum")]
        None = 0,
        [Description("Produção")]
        Production = 1,
        [Description("Homologação")]
        Homologation = 2
    }
}
