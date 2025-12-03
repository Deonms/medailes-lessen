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
            bool running = true;
            while (running)
            {
                Console.WriteLine("Wat is jouw Naam?");
                string answer = Console.ReadLine();

                if (answer == "Deon")
                {
                    running = false;
                }
                Console.Clear();
            }
        }
    }
}
