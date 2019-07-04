using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewInventryApp
{
     class InstrumentSpec
    {
        private Dictionary<string,object> properties;
        public InstrumentSpec() { }

        public InstrumentSpec(Dictionary<string, object> properties)
        {
            if (properties == null)
            {
                this.properties =new  Dictionary<string, object>();
            }
            else
            {
                this.properties = new Dictionary<string, object>(properties);
            }
        }
       

        public object getProperty(string propertyName)
        {
            return properties[propertyName];
        }
        public Dictionary<string, object> getProperties()
        {
            return properties;
        }

        public bool matches(InstrumentSpec otherspec)
        {
            foreach(var i in otherspec.getProperties().Keys)
            {
                string properName = (string)i;
                if (!properties[properName].Equals(otherspec.getProperty(properName)))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
