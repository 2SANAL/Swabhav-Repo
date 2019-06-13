using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewInventryApp
{
    class Inventory
    {
        private List<Instrument> inventory;

        public Inventory()
        {
            inventory = new List<Instrument>();
        }

        public void AddInstrument(string serialno, double price, InstrumentSpace spec)
        {
            Instrument instrument = null;
            if (spec is GuitarSpec)
            {
                instrument = new Guitar(serialno, price, (GuitarSpec)spec);

            }
            if (spec is MandolinSpec)
            {
                instrument = new Mandolin(serialno, price, (MandolinSpec)spec);
            }
            inventory.Add(instrument);
        }

        public Instrument Get(string serialno)
        {
            foreach (Instrument instrument in inventory)
            {
                if (instrument.GetSerialNo().Equals(serialno))
                {
                    return instrument;
                }
            }
            return null;
        }


        public List<Instrument> SearchGuitar(GuitarSpec searchGuitar)
        {
            List<Instrument> matchingGuitars = new List<Instrument>();
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i] is Guitar)
                {
                    if (inventory[i].GetSpec().matches(searchGuitar))
                        matchingGuitars.Add(inventory[i]);
                }
               

            }
            return matchingGuitars;
        }


        public List<Instrument> SearchMandolin(MandolinSpec searchMandolin)
        {
            List<Instrument> matchingMandolin = new List<Instrument>();


            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i] is Mandolin)
                {
                    if (inventory[i].GetSpec().matches(searchMandolin))
                        matchingMandolin.Add(inventory[i]);
                }


            }
            return matchingMandolin;
        }




    }
}
