﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankingLib
{

    public class Login
    {
        private bool _flage;

        public bool ConnectToDB(string username, string password)
        {

            var connection = new Connection().Connectionobj;

            var command = new SqlCommand("select Name, BankPassword from BankMaster where Name= '" + username
                + "' AND BankPassword='" + password + "'", connection);
            try
            {
                connection.Open();
                var sqlDataReader = command.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {

                        Console.WriteLine(sqlDataReader["Name"] + " " + sqlDataReader["BankPassword"]);

                        if (sqlDataReader.GetValue(0).Equals(username) &&
                            sqlDataReader.GetValue(1).Equals(password))
                        {
                            _flage = true;
                        }
                    }
                }
                else
                {
                    _flage = false;
                }
                sqlDataReader.Close();
                return _flage;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return _flage;
            }

            finally
            {
                command.Dispose();
                connection.Close();
            }

        }
    }
}