using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BankingLib
{
    public class DoTransaction
    {
        private bool _flag;
        public bool Transaction(double amount, string type, string username)
        {
            SqlConnection connection = new Connection().Connectionobj;
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                transaction = connection.BeginTransaction("SampleTransaction");

                command.Connection = connection;
                command.Transaction = transaction;
                if (type.Equals("Deposite"))
                {
                    _flag = Deposite(amount, type, username, connection, command, transaction);


                }
                if (type.Equals("withdrawal"))
                {
                    _flag = Withdrow(amount, type, username, connection, command, transaction);

                }

            }
            return _flag;
        }
        private bool Deposite(double amount, string type, string username, SqlConnection connection, SqlCommand command, SqlTransaction transaction)
        {
            try
            {
                command.CommandText =
                   "update BankMaster set Balance= Balance + @amount  where Name=@username";
                command.Parameters.Add("@amount", SqlDbType.Int);
                command.Parameters.Add("@username", SqlDbType.VarChar);
                command.Parameters["@username"].Value = username;
                command.Parameters["@amount"].Value = amount;
                command.ExecuteNonQuery();
                command.CommandText =
                  "insert into BankTransaction(Name,Amount,TransactionType,TransactionDate) values(@username1,@amount1,@type,@Date)";

                command.Parameters.Add("@amount1", SqlDbType.Int);
                command.Parameters.Add("@username1", SqlDbType.VarChar);
                command.Parameters.Add("@type", SqlDbType.VarChar);
                command.Parameters.Add("@Date", SqlDbType.VarChar);

                command.Parameters["@username1"].Value = username;
                command.Parameters["@amount1"].Value = amount;
                command.Parameters["@type"].Value = "Deposite";
                command.Parameters["@Date"].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

                command.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine("Both records are written to database.");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);
                _flag = false;
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
        private bool Withdrow(double amount, string type, string username, SqlConnection connection, SqlCommand command, SqlTransaction transaction)
        {
            try
            {
                command.CommandText =   
                    "update BankMaster set Balance= Balance - @amount  where Name=@username";

                command.Parameters.Add("@amount", SqlDbType.Int);
                command.Parameters.Add("@username", SqlDbType.VarChar);
                command.Parameters["@username"].Value = username;
                command.Parameters["@amount"].Value = amount;
                command.ExecuteNonQuery();
                command.CommandText =
                  "insert into BankTransaction(Name,Amount,TransactionType,TransactionDate) values(@username1,@amount1,@type,@Date)";

                command.Parameters.Add("@amount1", SqlDbType.Int);
                command.Parameters.Add("@username1", SqlDbType.VarChar);
                command.Parameters.Add("@type", SqlDbType.VarChar);
                command.Parameters.Add("@Date", SqlDbType.VarChar);

                command.Parameters["@username1"].Value = username;
                command.Parameters["@amount1"].Value = amount;
                command.Parameters["@type"].Value = "withdrawal";
                command.Parameters["@Date"].Value = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                command.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine("Both records are written to database.");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Commit Exception Type: {0}", ex.GetType());
                Console.WriteLine("  Message: {0}", ex.Message);
                _flag = false;
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