using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewInventryApp
{
    abstract class InstrumentSpace
    {
        private Builder _builder;
        private string _model;
        private Type _type;
        private Wood _backwood;
        private Wood _topwood;

        public InstrumentSpace(Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            _builder = builder;
            _model = model;
            _backwood = backWood;
            _topwood = topWood;
        }
        public Builder GetBuilder() { return _builder; }
        public string GetModel() { return _model; }
        public Type Gettype() { return _type; }
        public Wood GetBackwood() { return _backwood; }
        public Wood GetTopwood() { return _topwood; }

        public bool matches(InstrumentSpace otherspec)
        {
            if (_builder != otherspec.GetBuilder())
                return false;
            if ((_model != null) && (!_model.Equals("")) && (!_model.Equals(otherspec.GetModel())))
                return false;
            if (_type != otherspec.Gettype())
                return false;
            if (_backwood != otherspec.GetBackwood())
                return false;
            if (_topwood != otherspec.GetTopwood())
                return false;
            return true;
        }
    }
}
