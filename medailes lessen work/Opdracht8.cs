using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class Opdracht8
    {
        private string _username;
        private int _level;
        private int _lives;

        public Opdracht8(string username, int level, int Lives)
        {
            _username = username;
            _level = level;
            _lives = Lives;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Username: {_username} en deze user is level: {_level} en deze user heeft nog: {_lives} levens over");
        }
        }
    }



