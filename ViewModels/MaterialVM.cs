using ElectricBudget.Enums;
using ElectricBudget.Models;
using ElectricBudget.Models.Repository;
using ElectricBudget.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ElectricBudget.ViewModels
{
    public class MaterialVM : GenericVM
    {
        public string MaterialLabel { get; set; }
        public string IsActiveLabel { get; set; }
        public string MeasureLabel { get; set; }

        public Material MaterialItem { get; set; }

        public List<AvailableMeasure> Measures { get; set; }

        public ICommand SaveCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        private Action<bool> _setIsIndeterminate;
        private Action _closeWindowAction;

        private BackgroundWorker _worker;

        public MaterialVM(Action<bool> setIsIndeterminate, Action closeWindow)
        {         
            MaterialLabel = Utility.GetStringResource("TXT_MATERIAL_PT");
            IsActiveLabel = Utility.GetStringResource("TXT_ISACTIVE_MATERIAL_PT");
            MeasureLabel = Utility.GetStringResource("TXT_MEASURE_MATERIAL_PT");
            _setIsIndeterminate = setIsIndeterminate;
            _closeWindowAction = closeWindow;
            SaveCommand = new DelegateCommand(SaveMaterial, CanSaveMaterial);
            CloseCommand = new DelegateCommand(CloseWindow);

            MaterialItem = new Material();

            Measures = Service.GetInstance().GetMeasures();
            MaterialItem.Measure = Measures.Find(x => x.Id == 0);

            _worker = new BackgroundWorker();
            _worker.WorkerReportsProgress = true;
            _worker.DoWork += Worker_DoWork;         
            _worker.ProgressChanged += Worker_ProgressChanged;
            _worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            _worker.RunWorkerAsync();

            UpdateContext();
        }

        private void Worker_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            _setIsIndeterminate(true);
        }

        private void Worker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            _setIsIndeterminate(false);
        }

        private void Worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                (sender as BackgroundWorker).ReportProgress(i);
                Thread.Sleep(100);
            }
        }

        private void SaveMaterial(object obj)
        {
            MaterialRepository materialSave = new MaterialRepository();
            materialSave.Description = MaterialItem.Description;
            materialSave.Measure = MaterialItem.Measure.Id;
            materialSave.IsActive = MaterialItem.IsActive;

            if (Service.GetInstance().SaveMaterialChanges(materialSave) > 0)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("Os dados não foram salvos!");
            }
             
        }

        private bool CanSaveMaterial(object arg)
        {
            return !string.IsNullOrEmpty(MaterialItem.Description);
        }

        private void UpdateContext()
        {
            OnPropertyChanged(nameof(MaterialItem));
        }

        public void CloseWindow(object obj)
        {
            if (!_worker.IsBusy)
            {
                _closeWindowAction();
            }            
        }

    }
}
