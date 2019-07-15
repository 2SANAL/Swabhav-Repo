using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BankingLib.Repository
{
    public class Connection
    {
        private readonly SqlConnection _connection;

        public Connection()
        {
            _connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnection"].ToString());
        }

        public SqlConnection Connectiononobj
        {
            get
            {
                return _connection;
            }
        }
    }
}
