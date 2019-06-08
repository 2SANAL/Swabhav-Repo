using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ContactApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phonebook = new PhoneBook();

            while (true)
            {
                int userchoice;
                Console.WriteLine("1.Add Contact");
                Console.WriteLine("2.Display Contact");
                Console.WriteLine("3.Exit");
                userchoice = Convert.ToInt32(Console.ReadLine());

                if (userchoice == 1)
                {
                    Console.WriteLine("Enter Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter phne number");
                    double phonenumber = Convert.ToDouble(Console.ReadLine());
                    phonebook.AddContact(name, email, phonenumber);
                    Console.WriteLine("Add Contact");
                }
                if (userchoice == 2)
                {
                    ArrayList list = phonebook.ShowContact();
                    foreach (Contact contact in list)
                    {
                        ShowContactInformation(contact);
                    }
                }
                if (userchoice == 3)
                {
                    break;
                }
            }

        }
        static void ShowContactInformation(Contact contact)
        {
            Console.WriteLine("\n\tInformation");
            Console.WriteLine("Name:" + contact.Name + "\nPhone No:" + contact.PhoneNumber +
                "\nEmail:" + contact.Email);
            Console.WriteLine();
        }
    }
}
