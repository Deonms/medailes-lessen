using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class Character
    {
        private string _name;
        public Character(string name)
        {
            _name = name;
            Console.WriteLine($"dit Character met de naam { _name } is gemaakt");
            
        }
    }
}
