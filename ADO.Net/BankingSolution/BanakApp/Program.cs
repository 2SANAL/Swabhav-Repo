using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankingLib;
using System.Windows.Forms;

namespace BanakApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // NewMethod();
            //   NewMethod1();
            //Registration registor = new Registration();
            //          registor.Registor("Sanal1", "sanal", 500, "Deposite");

            DoTransaction d = new DoTransaction();
            d.Transaction(100, "withdrawal", "Sanal1");
            GetAllRecord g = new GetAllRecord();
            g.getData();
        }

        private static void NewMethod1()
        {
            Application.EnableVisualStyles();
            Application.Run(new PassBookForm());
        }

        private static void NewMethod()
        {
            string username;
            string password;

            PassBook passnool = new PassBook();
            passnool.PassBookPrint("Mit");
            GetAllRecord g = new GetAllRecord();
            g.getData();

           

            Login login = new Login();

            Console.WriteLine("Enter the Username");
            username = Console.ReadLine();
            Console.WriteLine("Enter the Password");
            password = Console.ReadLine();

            login.ConnectToDB(username, password);
        }
    }
}
