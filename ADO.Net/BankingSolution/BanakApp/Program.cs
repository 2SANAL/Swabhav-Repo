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
            NewMethod1();
        }

        private static void NewMethod1()
        {
            Application.EnableVisualStyles();
            Application.Run(new LoginForm());
        }

        private static void NewMethod()
        {
            string username;
            string password;

            PassBookRepositry passnool = new PassBookRepositry();
            passnool.GetTransaction("Mit");
            //   GetAllRecord g = new GetAllRecord();
            // g.getData();



            LoginRepositry login = new LoginRepositry();

            Console.WriteLine("Enter the Username");
            username = Console.ReadLine();
            Console.WriteLine("Enter the Password");
            password = Console.ReadLine();

            login.LoginValidation(username, password);
        }
    }
}
