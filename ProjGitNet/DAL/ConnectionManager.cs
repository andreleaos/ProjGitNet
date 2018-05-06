using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjGitNet.DAL
{
    public class ConnectionManager
    {
        private static readonly string connStr = 
            ConfigurationManager.ConnectionStrings["agendaDB"].ConnectionString;

        private static SqlConnection conn = null;

        private ConnectionManager()
        {

        }

        public static SqlConnection GetConnection()
        {
            if (conn == null)
                conn = new SqlConnection(connStr);

            return conn;
        }
    }
}
