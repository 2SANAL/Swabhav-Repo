using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace BankingLib
{
    public class GetBalanceRepositry
    {
        private string _balance;

        public string GetBalance(string username)
        {
            var connection = new Connection().Connectionobj;

            var command = new SqlCommand("select Balance from BankMaster where Name='" + username + "'", connection);

            try
            {
                connection.Open();
                var sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        _balance = Convert.ToString(sqlDataReader.GetValue(0));
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
                _balance = "Filed to Load Balance";
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }
            return _balance;
        }
    }
}