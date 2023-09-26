using ElectricBudget.Services;
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

            lbl_version.Text = Service.GetInstance().GetEnvironment();
            lbl_version_number.Text =  " - " + GetAssemblyVersion();
        }

        public void LoadContext()
        {
            this.DataContext = new HomeVM(OpenMaterial);
        }
        
        private void OpenMaterial()
        {
            new wpfMaterial().ShowDialog();
        }

        private string? GetAssemblyVersion()
        {
            //https://stackoverflow.com/questions/909555/how-can-i-get-the-assembly-file-version
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }
    }
}
