using ElectricBudget.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ElectricBudget.ViewModels
{
    public class HomeVM : GenericVM
    {
        private Action _createMaterial;
        private Action _createUser;
        public ICommand CreateMaterialCommand { get; set; }
        public ICommand CreateUserCommand { get; set; }
        public bool MyProperty { get; set; }


        public HomeVM(Action createMaterial, Action createUser)
        {
            CreateMaterialCommand = new DelegateCommand(CreateMaterial, CanCreateMaterial);
            CreateUserCommand = new DelegateCommand(CreateUser, CanCreateUser);

            _createMaterial = createMaterial;
            _createUser = createUser;

            Service service = new Service();
            service.SetInstance(service);
        }

        private bool CanCreateUser(object arg)
        {
            return true;
        }

        private void CreateUser(object obj)
        {
            _createUser();
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
