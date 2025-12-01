using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    

    internal class Student
    {
        private string _name;
        private int _leeftijd;
        private string _achternaam;
        private string _friendname;
        private int _friendleeftijd;
        private string _friendachternaam;
        public void jezelf(string name, int leeftijd, string achternaam)
        {
            _name = name;
            _leeftijd = leeftijd;
            _achternaam = achternaam;
            Console.WriteLine($"Je naam is {name} en je achternaam is {achternaam} en je bent {leeftijd} jaar oud");
            }
        public void vriend(string friendname, int friendleeftijd, string friendachternaam)
        {
            _friendname = friendname;
            _friendleeftijd = friendleeftijd;
            _friendachternaam = friendachternaam;
            Console.WriteLine($"Je vriend heet dus {friendname} en zijn/haar achternaam is {friendachternaam} en hij/zij is {friendleeftijd} jaar oud");
        }
    }

    
}
