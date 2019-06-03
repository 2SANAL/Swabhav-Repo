using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RickGuitarAPP
{
    class Program
    {
        
       
        
    static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            
            
            //inventory.AddGuitar("V95693",Builder.FRENDER.ToString(), "stratocastor",Type.ACOUSTIC.ToString(),Wood.BRAZILIAN.ToString(),Wood.BRAZILIAN.ToString(),1499.5);
            Guitar whatErinLikes = new Guitar("", Builder.FRENDER, "stratocastor", Type.ACOUSTIC, Wood.BRAZILIAN, Wood.BRAZILIAN, 1499.5);
            
           List< Guitar> guitar = inventory.search(whatErinLikes);
            if(guitar !=null)
            {
                Console.WriteLine("Erin you ust like this " +
                    guitar.GetBuilder() + " " + guitar.GetModel() + " " + guitar.GetType() + " guitar: \n " + guitar.GetBackWood() +
                    " Back  and sides \n" + guitar.GetTopWood() + " top .\n You have it for only $ " + guitar.GetPrice());
           

            }
            else
            {
                Console.WriteLine("Srroy , Erin nothin for you");
            }
        }

    }
}
