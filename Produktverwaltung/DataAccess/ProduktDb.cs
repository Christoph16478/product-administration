using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produktverwaltung.DataAccess
{
    /// <summary>Data Access Layer class <c>ProductDb</c>
    /// operates with the database.</summary>
    public class ProduktDb
    {
        private static string _MyConnectionString;
        internal static string MyConnectionString
        {
            get { return _MyConnectionString; }
            private set { _MyConnectionString = value; }
        }

        internal static string MyConnectionString2
        {
            get { return GetConnectionStrings(); }
        }

        /// <summary>Static constructor for the <c>ProductDb</c>
        /// class. Login data retrieved from <c>App.config</c>
        /// file.</summary>
        static ProduktDb()
        {
            MyConnectionString = GetConnectionStrings();
        }

        internal static SqlConnection
        SqlConnection(string AppConfigEntry = "SqlServer")
        {
            SqlConnection con = new
            SqlConnection(GetConnectionStrings(AppConfigEntry));
            return con;
        }

        internal static string
        GetConnectionStrings(string AppConfigEntry = "SqlServer")
        {
            string connection = "";
            try
            {
                var aConnections =
                System.Configuration.ConfigurationManager.
                ConnectionStrings[AppConfigEntry];

                if (aConnections != null)
                {
                    connection = aConnections.ToString();
                }
            }
            catch (Exception ex) {}
            return connection;
        }
    }
}
