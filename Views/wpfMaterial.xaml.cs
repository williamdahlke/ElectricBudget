using ElectricBudget.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ElectricBudget.Views
{
    /// <summary>
    /// Interaction logic for wpfMaterial.xaml
    /// </summary>
    public partial class wpfMaterial : Window
    {
        public wpfMaterial()
        {
            InitializeComponent();
            LoadContext();
        }

        public void LoadContext()
        {
            this.DataContext = new MaterialVM();
        }
    }
}
