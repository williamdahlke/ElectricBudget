using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBudget.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CellphoneNumber { get; set; }
        public string Address { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }

        public Customer()
        {
            IsActive = true;
        }
    }
}
