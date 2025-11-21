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
        static void Main(string[] args)
        {
            Console.WriteLine(CheckOfNummerGroterIsDan0(5));
        }
    
        private static bool CheckOfNummerGroterIsDan0(int getal)
        {
            return getal > 0;                      
        }
    }
}