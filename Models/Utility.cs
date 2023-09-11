﻿using ElectricBudget.Enum;
using ElectricBudget.StringResources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ElectricBudget.Models
{
    internal static class Utility
    {
        private static ResourceManager _resourceManager;
        private static CultureInfo _cultureInfo;

        public static void SetResourceManager(Language language)
        {
            _resourceManager = new ResourceManager(typeof(GenericStringResource));
            SetCulture(language);
        }

        public static string GetStringResource(string resourceName)
        {
            string? stringResult = _resourceManager.GetString(resourceName, _cultureInfo);
            if (stringResult == null)
            {
                return string.Empty;
            }
            return stringResult;
        }

        private static void SetCulture(Language language)
        {
            if (language == Language.Portuguese)
            {
                _cultureInfo = new CultureInfo("pt-BR");
            }
            _cultureInfo = new CultureInfo("en-US");
        }

    }
}