using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewInventryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            InitializeInventroy(inventory);

            MandolinSpec whatErinLikes = new MandolinSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Style.A, Wood.ALDER, Wood.ALDER);
            GuitarSpec whatErinLikes1 = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, 12, Wood.ALDER, Wood.ALDER);

            if (whatErinLikes is MandolinSpec)
            {
                List<Instrument> matchingMandolin = inventory.SearchMandolin(whatErinLikes);

                if (matchingMandolin.Count >= 0)
                {
                    Console.WriteLine("Erin,you might like these Mandolin:");
                    foreach (Mandolin mandolin in matchingMandolin)
                    {
                        MandolinSpec spec = (MandolinSpec)mandolin.GetSpec();
                        Console.WriteLine("We have a " + spec.GetBuilder() + " " + spec.GetModel() + " " + spec.GetStyle() + " String " +
                            spec.Gettype() + " guitar:\n    " +
                            spec.GetBackwood() + " back and sides,\n    " +
                            spec.GetTopwood() + " top. \n You cac have it for only $" +
                            mandolin.GetPrice() + "!\n  ----");
                    }
                }
                else
                    Console.WriteLine("Sorry, Erin We have nothing for you!");
                if (whatErinLikes1 is GuitarSpec)
                {
                    List<Instrument> matchingGuitar = inventory.SearchGuitar(whatErinLikes1);

                    if (matchingGuitar.Count >= 0)
                    {
                        Console.WriteLine("Erin,you might like these Mandolin:");
                        foreach (Guitar guitar in matchingGuitar)
                        {
                            GuitarSpec spec = (GuitarSpec)guitar.GetSpec();
                            Console.WriteLine("We have a " + spec.GetBuilder() + " " + spec.GetModel() + " " + spec.Getnumstring() + " String " +
                                spec.Gettype() + " guitar:\n    " +
                                spec.GetBackwood() + " back and sides,\n    " +
                                spec.GetTopwood() + " top. \n You cac have it for only $" +
                                guitar.GetPrice() + "!\n  ----");
                        }
                    }
                    else
                        Console.WriteLine("Sorry, Erin We have nothing for you!");

                }
            }


        }
        static void InitializeInventroy(Inventory inventory)
        {
            inventory.AddInstrument("V9569", 1499.95, new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, 12, Wood.ALDER, Wood.ALDER));
            inventory.AddInstrument("V9512", 1549.95, new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, 12, Wood.ALDER, Wood.ALDER));
            inventory.AddInstrument("V9513", 1540.95, new MandolinSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Style.A, Wood.ALDER, Wood.ALDER));
            inventory.AddInstrument("V9413", 1500.95, new MandolinSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Style.A, Wood.ALDER, Wood.ALDER));
        }
    }
}
