using System;


namespace UrlInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = args[0];
           // Console.WriteLine(url);
            string[] str = url.Split(new char[] {'/',':','?',',','=','&','.'} );
           
            int i = 0;

            while (i < str.Length)
            {
         
                if (str[i].Equals("www"))
                {
                    Console.WriteLine("Company Name "+ str[i + 1]);
                }
                if (str[i].Equals("developer"))
                {
                    Console.WriteLine("Devloper Name " + str[i + 1]);
                }
                if (str[i].Equals("location"))
                {
                    Console.WriteLine("Location Name " + str[i + 1]);
                }
                i = i + 1;
            }
        }
    }
}
