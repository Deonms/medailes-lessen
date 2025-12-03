using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class Opdracht6
    {
        public void Start()
        {
            int i = 0;
            Console.WriteLine("geeft een cijfer");
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Dit is geen cijfer");
            }

            int imax = 17;
            int imin = 0;
            int[] numberguesserarray = { 54, 3734, 8734, 1, 35, -436, 9456, 287, 6454, 6782, 729, 392, -39573, 25, 2009, 38, -2009 };
            int numberguesser = numberguesserarray[i];
            for (i > imax)
            {
                if (i > imax)
                {
                    i = i / 10;
                }
            }
                if (i < imin)
            {
                i = i * imin;
            }
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
                if (answer == numberguesser)
                {
                    running = false;
                    Console.WriteLine($"Je hebt gewonnen in {tries} beurten");
                }
                if (answer > numberguesser)
                {
                    tries = tries + 1;
                    Console.WriteLine($"Lager, beurten al gedaan {tries}");
                }
                else if (answer < numberguesser)
                {
                    tries = tries + 1;
                    Console.WriteLine($"Hoger, beurten al gedaan {tries}");
                }
            }
        }
    }
}
