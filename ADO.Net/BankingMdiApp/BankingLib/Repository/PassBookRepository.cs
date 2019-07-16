    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SqlClient;
    using System.Data;

    namespace BankingLib.Repository
    {
        public class PassBookRepository
        {
            private readonly List<TransactionData> _list;

            public PassBookRepository()
            {
                _list = new List<TransactionData>();
            }

            public List<TransactionData> GetTransaction(string username)
            {
                var connection = new Connection().Connectiononobj;
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
                            var newLine = new TransactionData(sqlDataReader["Name"], sqlDataReader["Amount"], sqlDataReader["TransactionType"], sqlDataReader["TransactionDate"]);
                            _list.Add(newLine);
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
