using ElectricBudget.ViewModels;
using ElectricBudget.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ElectricBudget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HomeVM vm;

        public MainWindow()
        {
            InitializeComponent();
            LoadContext();
        }

        public void LoadContext()
        {
            this.DataContext = new HomeVM(OpenMaterial);
        }
        
        private void OpenMaterial()
        {
            new wpfMaterial().ShowDialog();
        }
    }
}
