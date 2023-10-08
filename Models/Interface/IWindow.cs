using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBudget.Models.Interface
{
    public interface IWindow
    {
        void LoadViewContext();

        void RefreshWindow();

    }
}
