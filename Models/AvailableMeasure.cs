using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBudget.Models
{
    public class AvailableMeasure
    {
        public int Id { get; set; }
        public string Measure { get; set; }
        public string Description { get; set; }

        public AvailableMeasure()
        {
        }

        public AvailableMeasure(int id, string measure, string description)
        {
            Id = id;
            Measure = measure;
            Description = description;
        }
    }
}
