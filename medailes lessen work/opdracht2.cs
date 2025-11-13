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
            Console.WriteLine("Je Staat Nu in een Hal bij De ingang (Ingangs Hal) naar welke kamer wil je? Huiskamer, Kelder, 2de Verdieping  (er zijn 4 eindes en 5 fout keuzes)");
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
                    Console.WriteLine("je bent hier heen gegaan voor niks dus je bent af (foute keuze 4 = wat deed ik hier?)");
                }
                else
                {
                    Console.WriteLine("Dit is NIET een geldige kamer of je hebt het niet goed gespelt");
                }

            }
            else if (Kamer1 == "Kelder")
            {
                Console.WriteLine("je bent naar " + Kamer1 + " gegaan naar welke kamer wil je nu?: Opslag, Wijn Kelder, Ingangs Hal");
                string Kamer2 = Console.ReadLine();
                if (Kamer2 == "Ingangs Hal")
                {
                    Console.WriteLine("Je realiseert dat de deur op het slot is gevallen toen je naar beneden liep (foute keuze 2 = Opgesloten)");
                }
                else if (Kamer2 == "Wijn Kelder")
                {
                    Console.WriteLine("Je Hebt je Dronken Gedronken waardoor je flauw bent gevallen (foute keuze 3 = Dronken");
                }
                else if (Kamer2 == "Opslag")
                {
                    Console.WriteLine("Je bent naar de " + Kamer2 + " Gegaan en je hebt een ijzeren Bijl gevonden die je mee neemt waar wil je nu naar toe? Wijn Opslag, Ingangs Hal, 2de Opslag");
                    string Kamer3 = Console.ReadLine();
                    if (Kamer3 == "2de Opslag")
                    {
                        Console.WriteLine("Je hebt voor " + Kamer3 + " Gekozen maar je hebt er niks aan (foute keuze 4 = wat deed ik hier?)");
                    }
                    else if (Kamer3 == "Ingangs Hal")
                    {
                        Console.WriteLine("Terwijl je naar boven loopt kom je er achter dat de deur opslot zit dus je gebruikt je ijzeren bijl om de deur open te breken (ending 3 = Vrijheid)");
                    }
                    else if (Kamer3 == "Wijn Kelder")
                    {
                        Console.WriteLine("Je Hebt  je Dronken Gedronken waardoor je flauw bent gevallen (foute keuze 3 = Dronken");
                    }
                    else
                    {
                        Console.WriteLine("Dit is NIET een geldige kamer of je hebt het niet goed gespelt");
                    }
                }
                else
                {
                    Console.WriteLine("Dit is NIET een geldige kamer of je hebt het niet goed gespelt");
                }
            }
            else if (Kamer1 == "2de Verdieping")
            {
                Console.WriteLine("je bent naar " + Kamer1 + " waar wil je nu naar toe?: Slaapkamer, Zolder, Toilet");
                string kamer2 = Console.ReadLine();
                if (kamer2 == "Slaapkamer")
                {
                    Console.WriteLine("Wil je Gaan Slapen? (Ja of Nee)");
                    string jaofnee = Console.ReadLine();
                    if (jaofnee == "Ja")
                    {
                        Console.WriteLine("je bent gaan slapen (ending 4 = slaap lekker)");
                    }
                    else if (jaofnee == "Nee")
                    {
                        Console.WriteLine("je bent gevallen op de grond omdat je moe was (foute keuze 5 = veelste moe om wakker te Blijven)");
                    }
                    else
                    {
                        Console.WriteLine("Dit is NIET een geldige Optie of je hebt het niet goed gespelt");
                    }
                }
                else if (kamer2 == "Zolder")
                {
                    Console.WriteLine("Je liep naar boven toe naar de " + kamer2 + " maar het val luik valt op slot achter je en er is ook geen raam om uit te ontsnappen (foute keuze 2 = Opgesloten)");
                }
                else if (kamer2 == "Toilet")
                {
                    Console.WriteLine("je bent naar de wc gegaan en je moest ook heel nodig (ending 2 = hoge nood)");
                }
                else
                {
                    Console.WriteLine("Dit is NIET een geldige kamer of je hebt het niet goed gespelt");
                }
            }
            else
            {
                Console.WriteLine("Dit is NIET een geldige kamer of je hebt het niet goed gespelt");
            }

        }
    }
}
