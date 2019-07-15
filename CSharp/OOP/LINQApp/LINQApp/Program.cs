using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace LINQApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] studentName = { "Sanal", "Akash", "Dhruv", "Priyansh", "Mit", "Dipesh" };
            IEnumerable<string> enumerableStudentName = studentName;

            IEnumerable<string> enumerablewithContenceA = enumerableStudentName
                .Where((n) => n.Contains("a"))
                .OrderBy((n) => n)
                .Take(2);

            foreach (string n in enumerablewithContenceA)
            {
                Console.WriteLine(n);
            }

            string[] directories =Directory.GetDirectories(@"C:/Windows/System32/");
            string[] foldername=new string[directories.Length];

            int i = 0;
            foreach (string folder in directories)
            {
                foldername[i] = Path.GetFileName(folder);
                i++;
            }

            IEnumerable<string> containsSizeGreatorthan5 = foldername
                .Where((d) => d.Length >= 5)
                .OrderBy((n) => n);

            foreach (string n in containsSizeGreatorthan5)
            {
                Console.WriteLine(n);
            }

        }
    }
}
