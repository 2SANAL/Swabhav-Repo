using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder movies = new Folder("Movies");
            File abc = new File("Abc", ".avc", 1234);
            File pqr = new File("pqr", ".avc", 1004);
            movies.AddItem(abc);
            movies.AddItem(pqr);

            Folder Hindi = new Folder("Hindi");
            File lanagn = new File("lgan", ".avc", 1004);
            Hindi.AddItem(lanagn);
            movies.AddItem(Hindi);

            Folder English = new Folder("English");
            File avtar = new File("avtar", ".avc", 1004);
            English.AddItem(avtar);
            movies.AddItem(English);

            Folder Comedy = new Folder("Comedy");
            File heraferi = new File("heraferi", ".avc", 1004);
            Comedy.AddItem(heraferi);
            movies.AddItem(Comedy);

            movies.AddItem(new File("z", ".avc", 1247));

            movies.Display(1);
        }
    }
}
