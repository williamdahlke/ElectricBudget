using ElectricBudget.Enums;
using ElectricBudget.Models;
using ElectricBudget.StringResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;

namespace ElectricBudget.Services
{
    internal class Service
    {
        private Language _language;
        private static Service _service;
        private DataContext _dataContext;
        private Enums.Environment _environment;


        public void SetInstance(Service service)
        {
            if (service != null)
            {
                _service = service;
            }            
        }

        public static Service GetInstance()
        {
            if (_service != null)
            {
                return _service;
            }
            return null;
        }

        public void SetLanguage(Language language)
        {
            _language = language;
        }

        public Service()
        {
            SetLanguage(Language.Portuguese);
            SetEnvironment(Enums.Environment.Production);
            Utility.SetResourceManager(Language.Portuguese);            
            SetDataContext();
        }

        public List<AvailableMeasure> GetMeasures()
        {
            List<AvailableMeasure> list = new List<AvailableMeasure>();
            foreach (Measure measure in typeof(Measure).GetEnumValues())
            {
                AvailableMeasure measureObject = new AvailableMeasure(Convert.ToInt32(measure), measure.ToString(), Utility.GetEnumDescription(measure));
                list.Add(measureObject);
            }
            list = list.OrderBy(measure => measure.Description).ToList();
            
            return list;
        }

        public string GetEnumDescription<T>(T enumType)
        {
            return Utility.GetEnumDescription(enumType);    
        }

        private void SetDataContext()
        {
            _dataContext = new DataContext();
        }

        public int SaveChanges()
        {
            return _dataContext.SaveChanges();
        }

        private void SetEnvironment(Enums.Environment environment)
        {
            _environment = environment;
        }

        public string GetEnvironment()
        {
            return Utility.GetEnumDescription(_environment);
        }
    }
}
