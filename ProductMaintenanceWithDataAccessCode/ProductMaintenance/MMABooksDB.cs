using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProductMaintenance
{
    public static class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = global::ProductMaintenance.Properties.Settings.Default.MMABooksConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
