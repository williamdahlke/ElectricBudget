using ElectricBudget.Enums;
using ElectricBudget.Models;
using ElectricBudget.Models.Repository;
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
        public string MeasureLabel { get; set; }

        public Material MaterialItem { get; set; }

        public List<AvailableMeasure> Measures { get; set; }

        public ICommand SaveCommand { get; set; }


        public MaterialVM()
        {
            MaterialLabel = Utility.GetStringResource("TXT_MATERIAL_PT");
            IsActiveLabel = Utility.GetStringResource("TXT_ISACTIVE_MATERIAL_PT");
            MeasureLabel = Utility.GetStringResource("TXT_MEASURE_MATERIAL_PT");

            MaterialItem = new Material();

            Measures = Service.GetInstance().GetMeasures();
            MaterialItem.Measure = Measures.Find(x => x.Id == 0);         
            
            SaveCommand = new DelegateCommand(SaveMaterial, CanSaveMaterial);

            UpdateContext();
        }

        private void SaveMaterial(object obj)
        {
            MaterialRepository materialSave = new MaterialRepository();
            materialSave.Description = MaterialItem.Description;
            materialSave.Measure = MaterialItem.Measure.Id;
            materialSave.IsActive = MaterialItem.IsActive;

            Service.GetInstance().SaveChanges();
        }

        private bool CanSaveMaterial(object arg)
        {
            return !string.IsNullOrEmpty(MaterialItem.Description);
        }

        private void UpdateContext()
        {
            NotifyPropertyChanged(nameof(MaterialItem));
        }
    }
}
