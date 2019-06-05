using System;
using System.Collections;


namespace RickGuitarAPP
{
   
       class Inventory
        {
            private ArrayList guitars;

            public Inventory()
            {
                guitars = new ArrayList();
            }

            public void AddGuitar(string serialno, double price, GuitarSpec spec)
            {
                Guitar guitar = new Guitar(serialno, price, spec);
                guitars.Add(guitar);
            }

            public Guitar GetGuitar(string serialno)
            {
                foreach (Guitar G in guitars)
                {
                if (G.GetSerialNumber().Equals(serialno))
                    {
                        return G;
                    }
                }
                return null;
            }

            public ArrayList Search(GuitarSpec searchGuitar)
            {
                ArrayList matchingGuitars = new ArrayList();
                foreach (Guitar G in guitars)
                {
                    if (G.getSpec().matches(searchGuitar))
                        matchingGuitars.Add(G);
                }
                return matchingGuitars;
            }

        }
    }