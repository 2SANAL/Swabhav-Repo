using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SqlInjectionSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string deptnumber;
            var connection = new SqlConnection(@"Data Source=.\MSSQLSERVER1;Initial Catalog=AurionPro;
                            Integrated Security=True");

            Console.WriteLine("Enter Deapartment Number ");
            deptnumber = Console.ReadLine();

            var command = new SqlCommand("select * from EMP where DEPTNO=@deptNo", connection);
            command.Parameters.Add("@deptNo", SqlDbType.Int);
            command.Parameters["@deptNo"].Value = deptnumber;
            try
            {
                connection.Open();
                var sqlDataReader = command.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine(sqlDataReader.GetValue(0)
                      + "   " + sqlDataReader.GetValue(1) + " " + sqlDataReader.GetValue(2) + " " +
                      sqlDataReader.GetValue(3) + " " + sqlDataReader.GetValue(5) + " " +
                      sqlDataReader.GetValue(6) + " " + sqlDataReader.GetValue(7));
                    }

                }
                else
                {
                    Console.WriteLine("Data Not found");
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
                if (connection.State.Equals(System.Data.ConnectionState.Open))
                    connection.Close();
            }


        }

    }
}