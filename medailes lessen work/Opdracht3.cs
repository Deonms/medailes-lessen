using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class Opdracht3
    {
        public void Start() 
        {
            Console.WriteLine("Wat voor weer is het Vandaag?: 1. Zon 2. Regen 3.Bewolkt. 4.Sneeuw 5.Iets anders");
            String Weer = Console.ReadLine();
            Console.WriteLine("en hoe warm is het vandaag?");
            String Graden = Console.ReadLine();
            if (Weer == "5")
            {
                Console.WriteLine("Sorry ik kan je dan helaas niet helpen");
            }
        }
    }
}
