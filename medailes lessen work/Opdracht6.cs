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
            int numbergeusser = 3478;
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
                int answer;
                while (!int.TryParse(Console.ReadLine(), out answer))
                {
                    Console.Clear();
                    tries = tries + 1;
                    Console.WriteLine($"Dit is geen cijfer, dit kost je ook een try {tries}");
                }
                Console.Clear();
                if (answer == numbergeusser)
                {
                    running = false;
                    Console.WriteLine($"Je hebt gewonnen in {tries} beurten");
                }
                if (answer > numbergeusser)
                {
                    tries = tries + 1;
                    Console.WriteLine($"Lager, beurten al gedaan {tries}");
                }
                else if (answer < numbergeusser)
                {
                    tries = tries + 1;
                    Console.WriteLine($"Hoger, beurten al gedaan {tries}");
                }
            }
        }
    }
}
