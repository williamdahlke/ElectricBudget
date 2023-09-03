using ElectricBudget.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ElectricBudget.ViewModels
{
    internal class HomeVM : GenericVM
    {
        private Action _createMaterial;
        public ICommand CreateMaterialCommand { get; set; }

        public HomeVM(Action openMaterial)
        {
            CreateMaterialCommand = new DelegateCommand(CreateMaterial, CanCreateMaterial);
            _createMaterial = openMaterial;

            Service service = new Service();
            service.SetInstance(service);
        }

        public void CreateMaterial(object obj)
        {
            _createMaterial();
        }

        public bool CanCreateMaterial(object obj)
        {
            return true;
        }


    }
}
