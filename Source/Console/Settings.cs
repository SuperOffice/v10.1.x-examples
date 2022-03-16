using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNet.v10.Example
{
    internal class Settings
    {
        internal static bool EnableScaffolding = false;
        internal static bool LogDebug = false;
        internal static bool LogError = false;
        internal static bool LogInformation = false;
        internal static string LogFolder = "";

        internal static bool LogToFile => false;

        internal static string DatabaseMajor => "MSSQL";
        internal static string DatabaseMinor => "15";
        internal static string Server => "My-DB-Server";
        internal static string DatabaseName => "DB-Name";
        internal static string DBPassword => "Db-Pwd";
        internal static string DBUser => $"{DatabaseName}";
        internal static string TablePrefix => "crm7";
        internal static string ConnectionString => $"Data Source={Server};Initial Catalog={DatabaseName};User ID={DBUser};Password={DBPassword}";
        internal static int CommandTimeout => 300;
        internal static bool ImpersonateDatabaseUser => false;
        internal static bool SystemAllowed => true;
    }
}
