using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace BankingLib
{
  public  class GetAllRecord
    {
       public void getData()
        {
            var connection = new Connection().Connectionobj;
       
            var command = new SqlCommand("select * from BankMaster", connection);

            try
            {
                connection.Open();
                var sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {

                        Console.WriteLine(sqlDataReader["Name"] + " " + sqlDataReader["BankPassword"]+" "+sqlDataReader["Balance"]);

                      
                    }
                }
                else
                {
                    Console.WriteLine("Failed login");
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
        }
    }
}