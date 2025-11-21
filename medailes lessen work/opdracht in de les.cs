using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class opdracht_in_de_les
    {
        private static bool CheckOfNummerGroterIsDan0()
        {
            bool GroterDan0;
            if (GroterDan0)
            {
                Console.WriteLine("Dit getal is groter dan 0");
            }
            else
            {
                Console.WriteLine("Dit getal is NIET groter dan 0");
            }
            Console.WriteLine("Geef me een getal");
            int getal = Convert.ToInt32(Console.ReadLine());
            if (getal > 0)
            {
                GroterDan0 = true;
                return GroterDan0;
            }
            else
            {
                GroterDan0 = false;
                return GroterDan0;
            }
            
        }
    }
}