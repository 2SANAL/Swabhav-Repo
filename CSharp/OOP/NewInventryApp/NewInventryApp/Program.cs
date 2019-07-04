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

            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("builder", Builder.COLLINGS);
            properties.Add("backWood", Wood.SITKA);
            properties.Add("builder1", Builder.COLLINGS);
            properties.Add("backWood1", Wood.SITKA);
            InstrumentSpec clientSpec = new InstrumentSpec(properties);

            List<Instrument> matchingInstrument = inventory.SearchInstrument(clientSpec);

            if (matchingInstrument.Count > 0)
            {
                Console.WriteLine("you might like these Instrument:");

                foreach (Instrument instrument in matchingInstrument)
                {

                    InstrumentSpec spec = instrument.GetSpec();

                    Console.WriteLine("We have a " + spec.getProperty("instrumentType") + "  with follwing Properties ");
                    foreach (var j in spec.getProperties().Keys)
                    {
                        string propertyName = Convert.ToString(j);
                        if (propertyName.Equals("instrumentType"))
                        {
                            continue;
                        }
                        Console.WriteLine(" "+propertyName+" :"+spec.getProperty(propertyName));
                    }
                    Console.WriteLine("You can have this "+spec.getProperty("instrumentType")+" $"+instrument.GetPrice()+"\n----");

                }
            }
            else
            {
                Console.WriteLine("Sorry,we have nothing fo you");
            }
        }
        static void InitializeInventroy(Inventory inventory)
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("instrumentType",InstrumentType.GUITAR);
            properties.Add("builder",Builder.COLLINGS);
            properties.Add("model", "CJ");
            properties.Add("numString",6);
            properties.Add("topWood", Wood.INDIAN_ROSEWOOD);
            properties.Add("backWood",Wood.SITKA);

            properties.Add("instrumentType1", InstrumentType.BASS);
            properties.Add("builder1", Builder.COLLINGS);
            properties.Add("model1", "CJ");
            properties.Add("numString1", 6);
            properties.Add("topWood1", Wood.INDIAN_ROSEWOOD);
            properties.Add("backWood1", Wood.SITKA);


            inventory.AddInstrument("1234", 250, new InstrumentSpec(properties));

            inventory.AddInstrument("123554", 650, new InstrumentSpec(properties));
        }
    }
}
