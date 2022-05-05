using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCode
{
    public class Connection
    {

        public static SqlConnection InitServerConnection()
        {
            string connectionString = "Server=localhost; Trusted_Connection=True";
            return new SqlConnection(connectionString);
        }

        public static SqlConnection InitPRDConnection()
        {
            string connectionString = "Server=localhost; Database=PRD; Trusted_Connection=True;";
            return new SqlConnection(connectionString);
        }


    }
}
