using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_III.Helpers
{
    public static class ConfigHelpers
    {
        public static string GetConfigFile()
        {
            return "Programmering III.exe";
        }

        public static void UpdateConfig(string key, string value, string fileName)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(fileName);
            configFile.AppSettings.Settings[key].Value = value;

            configFile.Save();
        }

        public static string ReadConfig(string key, string fileName)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(fileName);
            return configFile.AppSettings.Settings[key].Value;
        }
    }
}
