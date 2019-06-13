using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewInventryApp
{
    abstract class Instrument
    {
        private string _serialNo;
        private double _price;
        private InstrumentSpace _spec;
        

        public Instrument(string serialNumber, double price, InstrumentSpace instumentSpec)
        {
            _serialNo = serialNumber;
            _price = price;
            _spec = instumentSpec;
        }
        public string GetSerialNo() { return _serialNo; }
        public double GetPrice() { return _price; }
        public void SetPrice(double p) { _price = p; }
        
        public InstrumentSpace GetSpec()
        {
            return _spec;
        }
    }
}
