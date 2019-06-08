using System;
using System.Collections.Generic;


namespace CollectionApp
{
    class Program
    {
        static HashSet<string> hashset = new HashSet<string>();
        static void Main(string[] args)
        {
            hashset.Add("akash");
            hashset.Add("dhruv");
            hashset.Add("dipesh");
            hashset.Add("sanal");
            Display();
            Console.WriteLine("1.Delete");
            Console.WriteLine("2.read");
            Console.WriteLine("3.search");
            Console.WriteLine("4. Add");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            if (userchoice == 1)
            {
                Console.WriteLine("Enter deleted option");
                string option = Console.ReadLine();
                hashset.Remove(option);
                Display();
            }
            if (userchoice == 2)
            {
                Display();
            }
            if (userchoice == 3)
            {
                Console.WriteLine("Enter search data");
                string option = Console.ReadLine();

                ItemCheck(option);


            }
            if (userchoice == 4)
            {
                Console.WriteLine("Enter value to add");
                string value = Console.ReadLine();
                hashset.Add(value);
            }


        }
        public static void Display()
        {
            foreach (string item in hashset)
            {
                Console.WriteLine(item);
            }
        }
       public static void ItemCheck(string item)
        {
            if (hashset.Contains(item)==true)
            {
                Console.WriteLine("Found");
            }
            if (hashset.Contains(item)==false)
            {
                Console.WriteLine("Not Found");
            }

        }

    }

}

