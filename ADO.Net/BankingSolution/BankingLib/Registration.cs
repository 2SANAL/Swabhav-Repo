using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankingLib
{
    public class Registration
    {
        public void Registor(string username, string password, double balance, string type)
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
                       "insert into BankMaster values('" + username + "','" + password
                    + "'," + balance + ")";
                    command.ExecuteNonQuery();
                    command.CommandText =
                        "insert into BankTransaction(Name,Amount,TransactionType,TransactionDate) values('" + username + "',"
                    + balance + ",'" + type + "','" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "')";
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
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