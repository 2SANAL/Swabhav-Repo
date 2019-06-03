using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Palayers();
            Player sachine = new Player(3, "Sachine", GenderOptions.MALE);
            Player virat = new Player(4, "Virat", GenderOptions.MALE);
            sachine.Age = 40;
            virat.Age = 18;
            DisplayInfo(sachine);
            DisplayInfo(virat);
            Player elder = sachine.WhoElder(virat);
            Console.WriteLine(" \nElder Age " + elder.GetName());

        }

        private static void Palayers()
        {
            Player p1 = new Player(1, "Dhruv", GenderOptions.MALE);
            Player p2 = new Player(2, "Akash");
            p1.Age = 18;
            p2.Age = 58;
            DisplayInfo(p1);
            DisplayInfo(p2);   
        }

        static void DisplayInfo(Player obj)
        {
            Console.WriteLine("Player Name " + obj.GetName() + "\nId " + obj.GetId() + " \nGender " + obj.GetGender()+" \nAge "+obj.Age+"\n");
        }
    }
}
