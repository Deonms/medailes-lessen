using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class Opdracht6
    {
        public void Start()
        {
            int getalraad = 6;
            bool running = true;
            int maximum1 = 0;
            int tries = 0;
            while (running)
            {
                if (maximum1 == 0)
                {
                    Console.WriteLine("Raad het getal");
                    maximum1 = maximum1 + 1;
                }
                int answer = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (answer == 6)
                {
                    running = false;
                    Console.WriteLine($"Je hebt gewonnen in {tries} beurten");
                }
                if (answer > getalraad)
                {
                    tries = tries + 1;
                    Console.WriteLine($"Lager, beurten al gedaan {tries}");
                }
                else if (answer < getalraad)
                {
                    tries = tries + 1;
                    Console.WriteLine($"Hoger, beurten al gedaan {tries}");
                }
            }
        }
    }
}
