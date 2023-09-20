using ElectricBudget.Enums;

namespace ElectricBudget.Models
{
    internal class Material
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public Measure Measure { get; set; }

        public bool IsActive { get; set; }

        public Material()
        {
            IsActive = true;
        }
    }
}
