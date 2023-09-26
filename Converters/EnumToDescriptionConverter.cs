using ElectricBudget.Enums;
using ElectricBudget.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ElectricBudget.Converters
{
    internal class EnumToDescriptionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string description = string.Empty;

            if (value is Enum)
            {
                Enum valueResult = (Enum) value;
                description = Service.GetInstance().GetEnumDescription(valueResult);                
            }

            return description;                                
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
