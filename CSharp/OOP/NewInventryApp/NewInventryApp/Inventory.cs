using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace NewInventryApp
{
    class Inventory
    {
        private ArrayList inventory;

        public Inventory()
        {
            inventory = new ArrayList();
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

        public ArrayList SearchGuitar(GuitarSpec searchGuitar)
        {
            ArrayList matchingGuitars = new ArrayList();
            foreach (Guitar G in inventory)
            {
                if (G.GetSpec().matches(searchGuitar))
                    matchingGuitars.Add(G);
            }
            return matchingGuitars;
        }
        public ArrayList SearchMandolin(MandolinSpec searchMandolin)
        {
            ArrayList matchingMandolin = new ArrayList();
            foreach (Mandolin I in inventory)
            {
                if (I.GetSpec().matches(searchMandolin))
                    matchingMandolin.Add(I);
            }
            return matchingMandolin;
        }
    }
}
