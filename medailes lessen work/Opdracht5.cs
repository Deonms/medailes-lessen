using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class Opdracht5
    {
        public void Start()
        {
            Console.WriteLine("Wat wil je keer doen?");
            int getalkeer;
            while (!int.TryParse(Console.ReadLine(), out getalkeer))
            {
                Console.WriteLine("Dit is geen cijfer");
            }

            Console.WriteLine("en hoe vaak wil je het keer doen? (hoe groter de nummer hoe langer het duurt)");
            int maximumgetal;
            while (!int.TryParse(Console.ReadLine(), out maximumgetal))
            {
                Console.WriteLine("Dit is geen cijfer");
            }


            for (int i = 0; i <= maximumgetal; i++)
            {
                Console.WriteLine(getalkeer + " x " + i + " = " + getalkeer * i);
            }
           
        }
    }
}