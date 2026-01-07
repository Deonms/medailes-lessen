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
            user.Login();|
            
            Opdracht6 Opdracht6 = new Opdracht6();
            Opdracht6.Start();

            Opdracht7 Opdracht7 = new Opdracht7();
            Opdracht7.Start();
            

            List<Car> Carlist = new List<Car>();
            Car Car1 = new Car("Ibiza", "Seat", 5);
            Carlist.Add(Car1);
            Car Car2 = new Car("Agilia", "oppal", 5);
            Carlist.Add(Car2);
            foreach(Car car in Carlist)
            {
                car.printCarInfo();
            }
            */
            List<Opdracht8> Userlist = new List<Opdracht8>();
            Opdracht8 User1 = new Opdracht8("Yassir", 45, 4);
            Userlist.Add(User1);
            Opdracht8 User2 = new Opdracht8("Deon", 98, 9);
            Userlist.Add(User2);
            Opdracht8 User3 = new Opdracht8("Jamiro", 36, 7);
            Userlist.Add(User3);
            foreach (Opdracht8 user in Userlist)
            {
                user.ShowStats();
            }
        }
    }
}