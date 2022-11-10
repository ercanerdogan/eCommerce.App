using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Persistence
{
    public static class Configuration
    {
        public static string GetConnectionInfo(string sectionName)
        {
            ConfigurationManager configurationManager = new();

            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceApp.API"));
            configurationManager.AddJsonFile("appsettings.json");

            return configurationManager.GetConnectionString(sectionName);

        }
    }
}
