using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class Opdracht2
    {
        public void Start()
        {
            Console.WriteLine("Je Staat Nu in een Hal bij De ingang (Ingangs Hal) naar welke kamer wil je? Huiskamer, Kelder, 2de Verdieping  (er zijn 2 eindes en 3 fout keuzes)");
            string Kamer1 = Console.ReadLine();
            if (Kamer1 == "Huiskamer")
            {
                Console.WriteLine("Je Staat Nu in " + Kamer1 + " naar welke kamer wil je? Eetkamer, Keuken, Toilet");
                string Kamer2 = Console.ReadLine();
                if (Kamer2 == "EetKamer")
                {
                    Console.WriteLine("Je Staat Nu in " + Kamer2 + " naar welke kamer wil je? Keuken, Gang 2, Mystery Ladder");
                    string Kamer3 = Console.ReadLine();
                    if (Kamer3 == "Mystery Ladder" || Kamer3 == "Gang 2")
                    {
                        Console.WriteLine("Je bent af gegaan door " + Kamer3 + " want het liep dood (foute keuze 1 = dood lopend)");
                    }
                    else if (Kamer3 == "Keuken")
                    {
                        Console.WriteLine("je hebt gewonnen " + Kamer3 + " want je hebt eten gemaakt en in de keuken het opgegeten (Ending 1 = Eten)");
                    }
                    else
                    {
                        Console.WriteLine("Dit is NIET een geldige kamer of je hebt het niet goed gespelt");
                    }
                }
                else if (Kamer2 == "Keuken")
                {
                    Console.WriteLine("Je Staat Nu in " + Kamer2 + " naar welke kamer wil je? Eetkamer, Toilet, Huiskamer");
                    string Kamer3 = Console.ReadLine();
                    if (Kamer3 == "Eetkamer" || Kamer3 == "Huiskamer")
                    {
                        Console.WriteLine("je hebt gewonnen " + Kamer3 + " want je hebt eten gemaakt en in " + Kamer3 + " het opgegeten (Ending 1 = Eten)");
                    }
                    else if (Kamer3 == "Toilet")
                    {
                        Console.WriteLine("je hebt gewonnen omdat je naar " + Kamer3 + " en je moest ook heel nodig maar waarom heb je een Toilet bij de keuken? dat is    heel erg vies vind ik (ending 2 = hoge nood)");
                    }
                    else
                    {
                        Console.WriteLine("Dit is NIET een geldige kamer of je hebt het niet goed gespelt");
                    }
                }
                else if (Kamer2 == "Toilet")
                {
                    Console.WriteLine("je bent hier heen gegaan voor niks dus je bent af");
                }
                else
                {
                    Console.WriteLine("Dit is NIET een geldige kamer of je hebt het niet goed gespelt");
                }

            }
            else if (Kamer1 == "Kelder")
            {
                Console.WriteLine("je bent naar " + Kamer1 + " gegaan naar welke kamer wil je nu?: Opslag Ruimte, Wijn Opslag Kamer, Ingangs Hal");
                string Kamer2 = Console.ReadLine();
                if (Kamer2 == "Ingangs Hal")
                {
                    Console.WriteLine("Je realiseert dat de deur op het slot is gevallen toen je naar beneden liep (foute keuze 2 = Opgesloten");
                }
                else if  (Kamer2 == "Wijn Kelder")
                    {
                        Console.WriteLine("Je Hebt je Dronken Gedronken waardoor je flauw bent gevallen (foute keuze 3 = Dronken");
                    }
            }
            else
            {
                Console.WriteLine("Dit is NIET een geldige kamer of je hebt het niet goed gespelt");
            }

        }
    }
}
