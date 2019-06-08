using System;
using System.Collections.Generic;

namespace MapApp
{
    class Program
    {
        static Dictionary<string, string> dictionary = new Dictionary<string, string>();
        static void Main(string[] args)
        {

            int userchoice;
            string key;


            dictionary.Add("1", "akash");
            dictionary.Add("2", "Dhruv");
            dictionary.Add("3", "Dipesh");
            dictionary.Add("4", "Sanal");


            Display();
            
            Console.WriteLine("1 Delete");
            Console.WriteLine("2 Read");
            Console.WriteLine("3 search");
            Console.WriteLine("4. Add");
            Console.WriteLine("5. Update");

            userchoice = Convert.ToInt32(Console.ReadLine());

            if (userchoice == 1)
            {
                Console.WriteLine("Enter key you want to delete");
                key = (Console.ReadLine());
                dictionary.Remove(key);
                Display();
            }
            if (userchoice == 2)
            {
                Display();

            }
            if (userchoice == 3)
            {

                Console.WriteLine("Enter value you want to Search ");
                key = (Console.ReadLine());
                Console.WriteLine(dictionary[key]);


            }
            if (userchoice == 4)
            {

                Console.WriteLine("Enter key and value you want to Search ");
               string key1= (Console.ReadLine());
                string value1 = Console.ReadLine();
                dictionary.Add(key1, value1);
                
            }
            if (userchoice == 5)
            {
                Console.WriteLine("Enter key  ");
                string key1 = (Console.ReadLine());
                Console.WriteLine("Enter  value ");
                string value1 = (Console.ReadLine());
                dictionary[key1] = value1;
                Display();
            }

        }
        public static void Display()
        {
            foreach (KeyValuePair<string, string> data in dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", data.Key, data.Value);
            }
        }



    }
}
