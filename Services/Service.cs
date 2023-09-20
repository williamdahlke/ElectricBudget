using ElectricBudget.Enums;
using ElectricBudget.Models;
using ElectricBudget.StringResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;

namespace ElectricBudget.Services
{
    internal class Service
    {
        private Language _language;
        public string teste;
        static Service _service;

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
            Utility.SetResourceManager(Language.Portuguese);

            teste = "william";
        }

        public List<Measure> GetMeasures()
        {
            List<Measure> list = new List<Measure>();
            foreach (Measure measure in typeof(Measure).GetEnumValues())
            {
                list.Add(measure);
            }
            return list;
        }
    }
}
