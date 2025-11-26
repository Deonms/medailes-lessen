using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class Opdracht4
    {
        public void Start()
        {
            Console.WriteLine("in Welke jaartal ben je geboren? (Heel Jaartal)");
            int jaartal = Convert.ToInt32(Console.ReadLine());
            int jaar = DateTime.Now.Year - jaartal;
            Console.WriteLine("in Welke Maand ben je geboren? (Maand in Cijfers)");
            int MaandUser = Convert.ToInt32(Console.ReadLine());
            int Maand = DateTime.Now.Month - MaandUser;
            Console.WriteLine("hoeveelste dag ben je geboren? (Dag in Cijfers)");
            int dagUser = Convert.ToInt32(Console.ReadLine());
            int dag = DateTime.Now.Day - dagUser;
            Console.WriteLine(jaar + " Jaar " + Maand + " Maanden " + dag + " Dagen ");

            if(jaar >= 18)
            {
                Console.WriteLine("\nJe bent " + jaar + " en dus je mag stemmen");
            }
            else
            {
                Console.WriteLine("\nJe bent " + jaar + " en dus je mag nog niet stemmen");
            }
        }
    }
}
