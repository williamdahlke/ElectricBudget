using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBudget.ViewModels
{
    internal class GenericVM : ICloneable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual object Clone()
        {
            throw new NotImplementedException();
        }

        public void NotifyPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
