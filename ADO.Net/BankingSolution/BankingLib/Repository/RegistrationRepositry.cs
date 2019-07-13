using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace BankingLib
{
    public class RegistrationRepositry
    {
        public bool Registor(string username, string password, double balance, string type)
        {

            SqlConnection connection = new Connection().Connectionobj;
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                transaction = connection.BeginTransaction("SampleTransaction");

                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                       "insert into BankMaster values(@username ,@password,@balance)";
                    command.Parameters.Add("@username", SqlDbType.VarChar);
                    command.Parameters.Add("@password", SqlDbType.VarChar);
                    command.Parameters.Add("@balance", SqlDbType.Float);

                    command.Parameters["@username"].Value = username;
                    command.Parameters["@password"].Value = password;
                    command.Parameters["@balance"].Value = balance;
                    command.ExecuteNonQuery();
                    command.CommandText =
                        "insert into BankTransaction(Name,Amount,TransactionType,TransactionDate) values(@username1,@balance1,@type,@date)";
                    command.Parameters.Add("@balance1", SqlDbType.Int);
                    command.Parameters.Add("@username1", SqlDbType.VarChar);
                    command.Parameters.Add("@type", SqlDbType.VarChar);
                    command.Parameters.Add("@Date", SqlDbType.VarChar);

                    command.Parameters["@username1"].Value = username;
                    command.Parameters["@balance1"].Value = balance;
                    command.Parameters["@type"].Value = "Deposite";
                    command.Parameters["@date"].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                    command.ExecuteNonQuery();

                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                    Console.WriteLine("  Message: {0}", ex.Message);

                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                        Console.WriteLine("  Message: {0}", ex2.Message);
                    }
                    return false;
                }
                finally
                {
                    command.Dispose();
                    connection.Close();
                }
            }
        }
    }
}