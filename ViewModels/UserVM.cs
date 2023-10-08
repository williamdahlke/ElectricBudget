using ElectricBudget.Models;
using ElectricBudget.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ElectricBudget.ViewModels
{
    public class UserVM : GenericVM
    {
        public List<User> Users { get; set; }
        public User SelectedUser { get; set; }
        private Action _closeWindow { get; set; }

        public ICommand CloseCommand { get; set; }

        public UserVM(Action closeWindow)         
        {
            _closeWindow = closeWindow;
            CloseCommand = new DelegateCommand(CloseWindow);

            Users = new List<User>();
            Users.Add(new User(1, "william", "williamgdahlke@gmail.com", true, true));
            Users.Add(new User(1, "ana", "ana19.bs@gmail.com", true, true));
        }

        private void CloseWindow(object obj)
        {
            _closeWindow();
        }
    }
}
