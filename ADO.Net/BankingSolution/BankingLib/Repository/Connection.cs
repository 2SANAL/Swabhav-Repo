using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankingLib
{
    public class Connection
    {
        private SqlConnection _connection;

        public Connection()
        {
            _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString());
        }

        public SqlConnection Connectionobj
        {
            get
            {
                return _connection;
            }
        }
    }
}
