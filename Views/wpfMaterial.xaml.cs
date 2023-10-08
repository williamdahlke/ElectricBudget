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
    /// Interaction logic for wpfMaterial.xaml
    /// </summary>
    public partial class wpfMaterial : Window, IWindow
    {
        Action<bool> SetIsIndeterminate;
        Action CloseWindow;

        public wpfMaterial(Action<bool> setIsIndeterminate, Action closeWindow)
        {
            InitializeComponent();
            SetIsIndeterminate = setIsIndeterminate;
            CloseWindow = closeWindow;
            LoadViewContext();
        }

        public void LoadViewContext()
        {
            this.DataContext = new MaterialVM(SetIsIndeterminate, CloseWindow);
        }

        public void RefreshWindow()
        {
            throw new NotImplementedException();
        }
    }
}
