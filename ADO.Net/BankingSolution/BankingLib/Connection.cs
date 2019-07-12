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
            _connection = new SqlConnection(@"Data Source=.\MSSQLSERVER1;Initial Catalog=AurionPro;
                            Integrated Security=True");
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
