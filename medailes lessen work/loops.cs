using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class loops
    {
        public void Start()
        {
            /*bool running = true;
            while(running)
            {
                Console.WriteLine("Wat is jouw Naam?");
                string answer = Console.ReadLine();

                if (answer == "Deon")
                {
                    running = false;
                }
                Console.Clear();
            } */
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Dat was For loop");
            int a = 1;
            do
            {
                Console.WriteLine(a);
                a = a + 1;
            } while (a <= 10);
            Console.WriteLine("Dat was do while loop");
            int b = 1;
            while (b <= 10)
            {
                Console.WriteLine(b);
                b = b + 1;
            }
            Console.WriteLine("Dat was while loop");
            int[] c = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int number in c)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Dat was foreach loop");
        }
    }
}
