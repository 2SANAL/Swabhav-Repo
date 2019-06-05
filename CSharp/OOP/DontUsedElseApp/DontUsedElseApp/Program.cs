using System;


namespace DontUsedElseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dontusedelse dontusedelse = new Dontusedelse(12,25);
            //dontusedelse.GreaterAge();
            dontusedelse.withoutelse();
            Console.WriteLine("Highest age "+dontusedelse.greator());
            
        }
    }
}
