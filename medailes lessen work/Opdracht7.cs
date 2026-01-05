using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class Opdracht7
    {
        public void Start()
        {
            Console.WriteLine("Hoeveel Dobblestenen Wil jij Gooien?");
            Random random = new Random();
            int[] count = new int[6];
            int totalThrows = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < totalThrows; i++)
            {
                int @throw = random.Next(1, 7);
                count[@throw - 1]++;
            }

            int maxAmount = 0;
            int mostThrown = 0;

            for (int i = 0; i < count.Length; i++)
            {
                double percentage = (count[i] / (double)totalThrows) * 100;
                Console.WriteLine($"{i + 1}: {count[i]} keer ({percentage:F2}%)");

                if (count[i] > maxAmount)
                {
                    maxAmount = count[i];
                    mostThrown = i + 1;
                }
            }
            Console.WriteLine($"het meest gegooid getal is: {mostThrown} ({maxAmount} keer)");
        }

    }
}
