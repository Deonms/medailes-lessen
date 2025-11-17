using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class Opdracht3
    {
        public void Start() 
        {
            Console.WriteLine("Wat voor weer is het Vandaag?: 1. Zon 2. Regen 3.Bewolkt. 4.Sneeuw 5.Iets anders");
            String Weer = Console.ReadLine();
            Console.WriteLine("en hoe warm is het vandaag?");
            int Graden = Convert.ToInt32(Console.ReadLine());
            if (Weer == "5")
            {
                Console.WriteLine("Sorry ik kan je dan helaas niet helpen");
            }
            if (Weer == "1" && Graden >= 15)
            {
                Console.WriteLine("Het is Dus zonnig en het is " + Graden + " Graden ik raad aan om je intesmeren voordat jij je verbrant");
            }
            else if (Weer == "1" && Graden < 15)
            {
                Console.WriteLine("het is zonnig maar de graden zou er niet perse hoeven te zorgen dat je verbrand maar indien je wilt zou je jezelf kunnen insmeren");
            }
            if (Weer == "2" && Graden >= 15)
            {
                Console.WriteLine("het is mischien wel warm maar het regent dus je hoeft je niet intesmeren maar pak wel een paraplu of doe een regenjas aan");
            }
            else if (Weer == "2" && Graden < 15)
            {
                Console.WriteLine("Het Regent en het is koud doe een jas aan zodat je geen kou vat");
            }
            if (Weer == "3" && Graden >= 15)
            {
                Console.WriteLine("je hoeft geen jas aan te doen");
            }
            else if (Weer == "3" && Graden < 15)
            {
                Console.WriteLine("het is koud doe een jas aan zodat je geen kou vat");
            }


        }
    }
}
