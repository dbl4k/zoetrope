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
        private const String m_appDataFileName = "zoetrope.savedstate.xml";
        private const String m_appDataFolderName = "Zoetrope";

        public String GetApplicationConfigDirectoryPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), m_appDataFolderName);
        }

        public String GetApplicationConfigFilePath()
        {
            return Path.Combine(GetApplicationConfigDirectoryPath(), m_appDataFileName);
        }

        public Boolean ApplicationConfigDirectoryExists()
        {
            return Directory.Exists(GetApplicationConfigDirectoryPath());
        }

        public Boolean ApplicationConfigFileExists()
        {
            return File.Exists(GetApplicationConfigFilePath());
        }

    }
}
