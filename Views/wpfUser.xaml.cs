using ElectricBudget.Models.Interface;
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
    /// Lógica interna para wpfUser.xaml
    /// </summary>
    public partial class wpfUser : Window, IWindow
    {
        UserVM vm;

        public wpfUser()
        {
            InitializeComponent();
            LoadViewContext();
        }

        public void LoadViewContext()
        {
            vm = new UserVM();
            this.DataContext = vm;
        }

        public void RefreshWindow()
        {
            throw new NotImplementedException();
        }
    }
}
