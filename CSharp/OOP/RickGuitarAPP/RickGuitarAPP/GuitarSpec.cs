using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RickGuitarAPP
{
    class GuitarSpec
    {
         private string _serialNumber, _model;
        Type _type;
        Wood _topWood, _backWood; 
        Builder _builder;
        private double _price;
       

        public Guitar(string _serialNumber,Builder _builder, string _model, Type _type, Wood _topWood, Wood _backWood,  double _price)
        {
            this._serialNumber = _serialNumber;
            this._model = _model;
            this._type = _type;
            this._topWood = _topWood;
            this._backWood = _backWood;
            this._price = _price;
            this._builder = _builder;
        }

        

        public string GetSerialNumber()
        {
            return _serialNumber;
        }
        public double GetPrice()
        {
            return _price;
        }
        public Builder GetBuilder()
        {
            return _builder;
        }
        public string GetModel()
        {
            return _model;
        }
        public Type GetType()
        {
            return _type;
        }
        public Wood GetBackWood()
        {
            return _backWood;
        }
        public Wood GetTopWood()
        {
            return _topWood;
        }

    }
}
