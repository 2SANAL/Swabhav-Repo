using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;

namespace ConnectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new SqlConnection(@"Data Source =.\MSSQLSERVER1; Initial Catalog = AurionPro; Integrated Security = True");
            try
            {
                connection.Open();
                Console.WriteLine("State              : " + connection.State);
                Console.WriteLine("Data Base Name     :" + connection.Database);
                Console.WriteLine("Server Version     :" + connection.ServerVersion);
                Console.WriteLine("Connection TimeOUT :" + connection.ConnectionTimeout);
                Console.WriteLine("sonnection string   :" + connection.ConnectionString);
                Console.WriteLine("container " + connection.Container);
                Console.WriteLine("PacketSize" + connection.PacketSize);
                Console.WriteLine(connection.StatisticsEnabled);
                SqlCommand sql = new SqlCommand();
                

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (connection.State.Equals(System.Data.ConnectionState.Open))
                {
                    connection.Close();
                    Console.WriteLine("Connection Close");

                }


            }
        }
    }
}
