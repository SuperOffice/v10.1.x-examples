using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperOffice.Configuration;
using SuperOffice.Security.Principal;

namespace DevNet.v10.Example
{
    internal class ContextInitializer : IContextInitializer
    {
        public void InitializeContext(string contextIdentifier)
        {
            ConfigureSettings();
        }

        private static void ConfigureSettings()
        {
            //ConfigFile.Data.Session.Mode = "Thread";
            //ConfigFile.Services.DefaultMode = SuperOffice.CRM.Services.ServiceMode.Local;

            // Database: Set SuperOffice.Data.Database entry in the config-file.
            ConfigFile.Data.Database.DatabaseMajor = Settings.DatabaseMajor;
            ConfigFile.Data.Database.DatabaseMinor = Settings.DatabaseMinor;
            ConfigFile.Data.Database.Server = Settings.Server;
            ConfigFile.Data.Database.DatabaseName = Settings.DatabaseName;
            ConfigFile.Data.Database.TablePrefix = Settings.TablePrefix;
            ConfigFile.Data.Database.ConnectionString = Settings.ConnectionString;
            ConfigFile.Data.Database.CommandTimeout = Settings.CommandTimeout;
            ConfigFile.Data.Database.ImpersonateDatabaseUser = Settings.ImpersonateDatabaseUser;

            // Explicit: Set database authentication Issues.
            ConfigFile.Data.Explicit.DBUser = Settings.DBUser;
            ConfigFile.Data.Explicit.DBPassword = Settings.DBPassword;
            ConfigFile.Data.Explicit.SystemAllowed = Settings.SystemAllowed;

            //Diagnostics: Configure logging
            ConfigFile.Diagnostics.LogToFile = Settings.LogToFile;
            ConfigFile.Diagnostics.LogFolder = Settings.LogFolder;
            ConfigFile.Diagnostics.EnableScaffolding = Settings.EnableScaffolding;
            ConfigFile.Diagnostics.LogDebug = Settings.LogDebug;
            ConfigFile.Diagnostics.LogError = Settings.LogError;
            ConfigFile.Diagnostics.LogInformation = Settings.LogInformation;
        }
    }
}
