using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBudget.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdministrator { get; set; }
      
        public User() 
        { 
        }

        public User(int id, string name, string email, bool isActive, bool isAdministrator)
        {
            Id = id;
            Name = name;
            Email = email;
            IsActive = isActive;
            IsAdministrator = isAdministrator;
        }
    }
}
