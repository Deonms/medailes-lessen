using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Wat is je naam en je leeftijd?");
            string naam = Console.ReadLine();
            string leeftijd = Console.ReadLine();
            Console.WriteLine("Hallo, " + naam + " Dus je bent " + leeftijd + " jaar oud");
            
            Opdracht2 test = new Opdracht2();
            test.Start();

            Opdracht3 Opdracht3 = new Opdracht3();
            Opdracht3.Start();
            
            /*
            opdracht_in_de_les opdracht_in_de_les = new opdracht_in_de_les();
            opdracht_in_de_les.Main();
            */
        }
    }
}
