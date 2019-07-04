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

        public void AddInstrument(string serialno, double price, InstrumentSpec spec)
        {
            Instrument instrument = new Instrument(serialno, price,spec);

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


        public List<Instrument> SearchInstrument(InstrumentSpec searchSpec)
        {
            List<Instrument> matchingInstrument = new List<Instrument>();
            foreach (Instrument instrument in inventory)
            {
                if (instrument.GetSpec().matches(searchSpec))
                    matchingInstrument.Add(instrument);
            }
            return matchingInstrument;
        }


    }
}
