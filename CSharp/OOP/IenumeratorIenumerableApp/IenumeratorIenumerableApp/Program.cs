using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IenumeratorIenumerableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            IEnumerable<string> ienumerable = (IEnumerable<string>)list;
           

            list.Add("akash");
            list.Add("dhruv");
            list.Add("dipesh");
            list.Add("sanal");

            Console.WriteLine("Display By Enumerable ");
            DisplayEnumerable(ienumerable);
            Console.WriteLine("Display By  Enumerator ");

            IEnumerator<string> ienumerator = list.GetEnumerator();
            while (ienumerator.MoveNext())
            {
                Console.WriteLine(ienumerator.Current);
            }

        }
        public static void DisplayEnumerable(IEnumerable<string> ienumerable)
        {
            foreach (string name in ienumerable)
            {
                Console.WriteLine(name);
            }
        }

    }
}
