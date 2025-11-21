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
        public void Start()
        {
            bool GroterDan8;
            Console.WriteLine("Geef me een getal");
            int getal = Convert.ToInt32(Console.ReadLine());
            if (getal > 0)
            {
                return true;
            }
        }
    }
}
