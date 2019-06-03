using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RickGuitarAPP
{
    class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }
        public void AddGuitar(string _serialNumber, Builder _builder, string _model, Type _type, Wood _topWood, Wood _backWood, double _price)
        {
            Guitar guitar = new Guitar(_serialNumber, _builder, _model, _type, _topWood, _backWood, _price);
            guitars.Add(guitar);

        }
        public Guitar GetGuitar(string _serialNumber)
        {
            foreach (var item in guitars)
            {
                Guitar guitar = item;
                if (guitar.GetSerialNumber().Equals(_serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }
        public List<Guitar> search(Guitar searchGuitar)
        {
            List<Guitar> machingGuitar = new List<Guitar>();

            foreach (var item in guitars)
            {
                Guitar guitar = item;
                string builder = searchGuitar.GetBuilder().ToUpper();
                if ((!builder.Equals(guitar.GetBuilder())))
                    continue;
                string model = searchGuitar.GetModel().ToUpper();
                if ( (!model.Equals(guitar.GetModel())))
                    continue;
                string type = searchGuitar.GetType().ToUpper();
                if ((!type.Equals(guitar.GetType())))
                    continue;
                string backwood = searchGuitar.GetBackWood().ToUpper();
                if ( (!backwood.Equals(guitar.GetBackWood())))
                    continue;
                string topwood = searchGuitar.GetTopWood().ToUpper();
                if ( (!topwood.Equals(guitar.GetTopWood())))
                    continue;
                machingGuitar.Add(guitar);
            }
            return machingGuitar;

        }

    }
}
