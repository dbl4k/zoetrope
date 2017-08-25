using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoetrope.Factories
{
    class ConfigurationFactory
    {
        private readonly String m_appDataFolderName = "Zoetrope";

        public String GetApplicationConfigDirectory()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), m_appDataFolderName);
        }

        public Boolean ApplicationConfigDirectoryExists()
        {
            return System.IO.Directory.Exists(GetApplicationConfigDirectory());
        }

    }
}
