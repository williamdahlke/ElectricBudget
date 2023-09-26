using ElectricBudget.Enums;
using System;

namespace ElectricBudget.Models
{
    internal class Material
    {
        public string Description { get; set; }

        public AvailableMeasure Measure { get; set; }

        public bool IsActive { get; set; }

        public Material()
        {
            IsActive = true;          
        }
    }
}
