using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Custmor custmor1 = new Custmor("akash", "jaiswal");
            Custmor custmor2 = new Custmor("Dhruv", "Ballikar");
            Custmor custmor3 = new Custmor("Dipesh", "More");
            DisplayINfo(custmor1);
            DisplayINfo(custmor2);
            DisplayINfo(custmor3);

        }
        public static void DisplayINfo(Custmor customer)
        {
            Console.WriteLine("Custmor ID " + customer.CustmorId +"   Gustomer First name"+customer.FirstName+" last name "+ customer.LastName);
        }
    }

}
