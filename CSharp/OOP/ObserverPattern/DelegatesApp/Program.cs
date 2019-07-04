using System;

namespace DelegatesApp
{
    public delegate void DPrintMessage(string name);

    class Program
    {
        static void Main(string[] args)
        {
            DPrintMessage message;
            DPrintMessage multiplemessage;

       
            message = PrintHello;
            message("Akash");
            message = PrintGoodBy;
            message("Akash");

            multiplemessage = PrintHello;
            multiplemessage += PrintGoodBy;
            multiplemessage += PrintHello;
            multiplemessage -= PrintHello;
            multiplemessage("AurionPro");

            PrintWizard(PrintHello);
            PrintWizard(PrintGoodBy);

        }

        private static void PrintHello(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }
        private static void PrintGoodBy(string name)
        {
            Console.WriteLine("Good By {0}", name);
        }

        static void Foo()
        {
            Console.WriteLine("Foo");
        }
        static void PrintWizard(DPrintMessage message)
        {
            Console.WriteLine("Champ");
        }

    }
}
