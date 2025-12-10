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
            int imax = 100;
            int imin = 0;
            int i = 0;
            int laatstgeradengetal;
            Console.WriteLine($"geeft een cijfer het lieftse onder {imax} en boven {imin} (je kan ook {imax} en {imin} kiezen)");
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Dit is geen cijfer");
            }

           
            int[] numberguesserarray = { 54, 3734, 8734, 1, 35, -436, 9456, 287, 6454, 6782, 729, 392, -3957, 25, 2009, 38, -2009, -6515, -6775, 6636, -9097, 204, -5939, 3722, 647, -8438, -7898, -1480, 1014, -6896, -8093, -940, 4523, -471, 5757, 6006, 1716, -2358, -2235, 5084, 747, -2276, 431, 5400, -6003, 7076, -9870, -6542, 1110, 3243, 2710, 1373, 2617, 4962, -2300, -2030, 1555, 1355, -4516, -821, -8032, -3296, 8583, -512, 1157, 6058, 7858, -1092, 7441, 7560, 5517, 7178, 8238, 6965, 1346, -3616, 226, 168, -8418, -9895, -4968, -3928, 7401, 8789, 8554, -4560, 1794, -3532, 5931, -9894, 7116, -5753, -4389, 2301, 9889, -4699, -3930, -3760, 8239, 5855, -7004 };
            int numberguesser = numberguesserarray[i];
            
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
                    laatstgeradengetal = answer;
                    Console.Clear();
                    tries = tries + 1;
                    Console.WriteLine($"Dit is geen cijfer, dit kost je ook een try {tries} je laatst geraden getal {laatstgeradengetal}");
                }
                Console.Clear();
                if (answer == numberguesser)
                {
                    laatstgeradengetal = answer;
                    running = false;
                    Console.WriteLine($"Je hebt gewonnen in {tries} beurten en het cijfer was {numberguesser}");

                }
                if (answer > numberguesser)
                {
                    laatstgeradengetal = answer;
                    tries = tries + 1;
                    Console.WriteLine($"Lager, beurten al gedaan {tries} je laatst geraden getal {laatstgeradengetal}");
                }
                else if (answer < numberguesser)
                {
                    laatstgeradengetal = answer;
                    tries = tries + 1;
                    Console.WriteLine($"Hoger, beurten al gedaan {tries} je laatst geraden getal {laatstgeradengetal}");
                }
                
            }
        }
    }
}
