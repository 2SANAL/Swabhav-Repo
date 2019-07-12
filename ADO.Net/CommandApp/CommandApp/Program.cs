using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;

namespace CommandApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection(@"Data Source=.\MSSQLSERVER1;Initial Catalog=AurionPro;
                            Integrated Security=True");
            var command = new SqlCommand("select * from EMP;", connection);
            try
            {
                connection.Open();
                var sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Console.WriteLine(sqlDataReader["ENAME"]
                        + "   " + sqlDataReader["SAL"]);
                }
                if (sqlDataReader.IsClosed == false)
                {
                    sqlDataReader.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                
                command.Dispose();
                if(connection.State.Equals(System.Data.ConnectionState.Open))
                connection.Close();
            }


        }

    }
}
