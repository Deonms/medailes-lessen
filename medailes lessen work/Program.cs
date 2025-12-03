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
            /*
            Console.WriteLine("Wat is je naam en je leeftijd?");
            string naam = Console.ReadLine();
            string leeftijd = Console.ReadLine();
            Console.WriteLine("Hallo, " + naam + " Dus je bent " + leeftijd + " jaar oud");
            
            Opdracht2 test = new Opdracht2();
            test.Start();
            
            Opdracht3 Opdracht3 = new Opdracht3();
            Opdracht3.Start();
            
            Opdracht4 Opdracht4 = new Opdracht4();
            Opdracht4.Start();
                        
          loops loops = new loops();
            loops.Start();

            Student student = new Student();
            student.jezelf("Deon", 16, "Maes");
            student.vriend("Yassir", 16, "Oullal");
            
            Opdracht5 Opdracht5 = new Opdracht5();
            Opdracht5.Start();

            bool admin = false;
            Console.WriteLine("Geef een Username");
            string Naam = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Geef een Wachtwoord op");
            string Wachtwoord = Console.ReadLine();
            Console.Clear();
            int age;
            Console.WriteLine("Wat is je leeftijd?");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Clear();
                Console.WriteLine("Voer alsjeblieft een nummer in en niet een woord");
            }
            Console.Clear();
            if (Naam == "Deon")
            {
                admin = true;
            }
            
            User user = new User(Naam, Wachtwoord, age, 1, admin);
            user.Login();
            */

            Opdracht6 Opdracht6 = new Opdracht6();
            Opdracht6.Start();

        }
    }
}