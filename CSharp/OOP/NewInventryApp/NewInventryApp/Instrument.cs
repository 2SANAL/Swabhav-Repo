using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewInventryApp
{
     class Instrument
    {
        private string _serialNo;
        private double _price;
        private InstrumentSpec _spec;
        

        public Instrument(string serialNumber, double price, InstrumentSpec instumentSpec)
        {
            _serialNo = serialNumber;
            _price = price;
            _spec = instumentSpec;
        }
        public string GetSerialNo() { return _serialNo; }
        public double GetPrice() { return _price; }
        public void SetPrice(double p) { _price = p; }
        
        public InstrumentSpec GetSpec()
        {
            return _spec;
        }
    }
}
