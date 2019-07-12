using System;
using System.Collections;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BankingLib
{
    public class PassBook
    {
        private SqlDataAdapter da;

        private string _filePath = @"E:/SwabhavTech/ADO.Net/transaction.csv";
        public SqlDataAdapter LoadData()
        {
            SqlConnection connection = new Connection().Connectionobj;

            string query = "select * from BankTransaction where Name='Akash'";

            da = new SqlDataAdapter(query, connection);
            connection.Open();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);

            return da;
        }

        public void PassBookPrint(string username)
        {
            var csv = new StringBuilder();

            var connection = new Connection().Connectionobj;
            string query = "select * from BankTransaction where Name='" + username + "'";
            var command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                var sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        var _newLine = string.Format("{0},{1},{2},{3}", sqlDataReader["Name"], sqlDataReader["Amount"], sqlDataReader["TransactionType"], sqlDataReader["TransactionDate"]);
                        csv.Append(_newLine);
                    }
                    File.WriteAllText(_filePath, csv.ToString());
                }
                else
                {
                    Console.WriteLine("Data not found");
                }
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
