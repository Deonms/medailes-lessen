using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class Car
    {
        private string _name;
        private string _brand;
        private int _numberOfDoors;

        public Car(string name, string brand, int numberOfDoors)
        {
            _name = name;
            _brand = brand;
            _numberOfDoors = numberOfDoors;
        }
            public void printCarInfo()
        {
            Console.WriteLine($"De naam van de auto is {_name} de de merk is {_brand} en hij heeft {_numberOfDoors} deuren");
        }
        }
    }

