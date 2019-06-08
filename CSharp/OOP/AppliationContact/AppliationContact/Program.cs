using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace AppliationContact
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PhoneBook phonebook = new PhoneBook();
            Service services = new Service();
            while (true)
            {
                int userchoice;
                Console.WriteLine("1.Add Contact");
                Console.WriteLine("2.Display Contact");
                Console.WriteLine("3. Search Contact");
                Console.WriteLine("4. Export Contact");
                Console.WriteLine("5.Exit");
                userchoice = Convert.ToInt32(Console.ReadLine());

                if (userchoice == 1)
                {
                    Console.WriteLine("Enter Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter phne number");
                    string phonenumber =(Console.ReadLine());
                    phonebook.AddContact(name, email, phonenumber);
                    Console.WriteLine("Add Contact");
                }
                if (userchoice == 2)
                {
                    List<Contact> list = phonebook.GetContact();
                    foreach (Contact contact in list)
                    {
                       services.ShowContactInformation(contact);
                    }
                }
                if (userchoice == 3)
                {
                    Console.WriteLine("Enter the deatails");
                    string details = Console.ReadLine();
                    services.SearchContac(details);
                }
                if (userchoice==4)
                {
                    services.ExportContact();
                }
                if (userchoice == 5)
                {
                    break;
                }
            }

        }
        
        
       
    }
}
