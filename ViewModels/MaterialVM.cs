using ElectricBudget.Models;
using ElectricBudget.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ElectricBudget.ViewModels
{
    internal class MaterialVM : GenericVM
    {
        public string MaterialLabel { get; set; }
        public string IsActiveLabel { get; set; }

        public Material MaterialItem { get; set; }

        public ICommand SaveCommand { get; set; }


        public MaterialVM()
        {
            MaterialLabel = Utility.GetStringResource("TXT_MATERIAL_PT");
            IsActiveLabel = Utility.GetStringResource("TXT_ISACTIVE_MATERIAL_PT");

            MaterialItem = new Material();

            SaveCommand = new DelegateCommand(SaveMaterial, CanSaveMaterial);
        }

        private bool CanSaveMaterial(object arg)
        {
            return true;
        }

        private void SaveMaterial(object obj)
        {
            MessageBox.Show(Service.GetInstance().teste);
        }
    }
}
