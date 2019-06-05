using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RickGuitarAPP
{
    class Guitar
    {
        private string _serialNumber;
        private double _price;
        private GuitarSpec _spec;
       

        public Guitar(string _serialNumber,  double _price,GuitarSpec _spec)
        {
            this._serialNumber = _serialNumber;
            this._price = _price;
            this._spec = _spec;
            
        }

        

        public string GetSerialNumber()
        {
            return _serialNumber;
        }
        public double GetPrice()
        {
            return _price;
        }
        public void setPrice(double p)
        {
            _price = p;
        }
     
        public GuitarSpec getSpec()
        {
            return _spec;
        }      


    }
}
