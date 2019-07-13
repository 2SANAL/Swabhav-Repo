using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using BankingLib;

namespace BankingLib
{
    public class PassBookRepositry
    {
        private SqlDataAdapter da;
        private List<TransactionData> _list;

        public PassBookRepositry()
        {
            _list = new List<TransactionData>();
        }
     
        public List<TransactionData> GetTransaction(string username)
        {
            var connection = new Connection().Connectionobj;
            string query = "select * from BankTransaction where Name= @username ";
            var command = new SqlCommand(query, connection);
            command.Parameters.Add("@username", SqlDbType.VarChar);
            command.Parameters["@username"].Value = username;
            try
            {
                connection.Open();
                var sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        var _newLine = new TransactionData(sqlDataReader["Name"],sqlDataReader["Amount"],sqlDataReader["TransactionType"],sqlDataReader["TransactionDate"]);
                        _list.Add(_newLine);
                    }
                }
                else
                {
                    Console.WriteLine("Data not found");
                }
                return _list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return _list;
            }
            finally
            {
                command.Dispose();
                connection.Close();
            }

        }
    }
}
