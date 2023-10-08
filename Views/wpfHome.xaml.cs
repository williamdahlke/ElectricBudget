using ElectricBudget.Models.Interface;
using ElectricBudget.Services;
using ElectricBudget.ViewModels;
using ElectricBudget.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Loader;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Provider;
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
    public partial class MainWindow : Window, IWindow
    {
        HomeVM vm;

        public MainWindow()
        {
            InitializeComponent();
            LoadViewContext();

            lbl_version.Text = Service.GetInstance().GetEnvironment();
            lbl_version_number.Text =  " - " + GetAssemblyVersion();
        }
        
        private void OpenMaterial()
        {
            wpfMaterial window = new wpfMaterial(SetIsIndeterminate, CloseWindow);
            this.frmHome.Navigate(window.Content);
        }

        private void OpenUser()
        {
            wpfUser window = new wpfUser();
            this.frmHome.Navigate(window.Content);
        }

        private string? GetAssemblyVersion()
        {
            //https://stackoverflow.com/questions/909555/how-can-i-get-the-assembly-file-version
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }

        public void LoadViewContext()
        {
            vm = new HomeVM(OpenMaterial, OpenUser);
            this.DataContext = vm;
        }

        public void RefreshWindow()
        {
            throw new NotImplementedException();
        }

        private void SetIsIndeterminate(bool value)
        {
            pbStatus.IsIndeterminate = value;
        }

        private void CloseWindow()
        {
            this.frmHome.Navigate(null);
        }
    }
}
