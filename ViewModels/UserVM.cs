using ElectricBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBudget.ViewModels
{
    public class UserVM : GenericVM
    {
        List<User> Users = new List<User>();

        public UserVM() 
        {
            Users.Add(new User(1, "william", "williamgdahlke@gmail.com", true));
            Users.Add(new User(1, "ana", "ana19.bs@gmail.com", true));
        }
    }
}
