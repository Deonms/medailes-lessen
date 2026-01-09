using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medailes_lessen_work
{
    internal class Opdracht9
    {
        private string _name;
        private string _weapontype;
        private int _damage;
        private int _DamageToAdd;
        private int _newDamage;
        private int _attackCooldown;
        private int _cost;

        public Opdracht9(string name, string weapontype, int damage, int DamageToAdd, int attackCooldown, int cost)
        {
            _name = name;
            _damage = damage;
            _DamageToAdd = DamageToAdd;
            _newDamage = _damage + _DamageToAdd;
            _weapontype = weapontype;
            _cost = cost;
            _attackCooldown = attackCooldown;

        }
        public void ShowStats()
        {
            Console.WriteLine($"\nName of weapon: {_name}");
            Console.WriteLine($"Weapon Type: {_weapontype}");
            Console.WriteLine($"weapon damage: {_damage}");
            Console.WriteLine($"Damage Upgrade: {_DamageToAdd}+");
            Console.WriteLine($"New Damage: {_newDamage}");
            Console.WriteLine($"Attack Couldown/Weapon Usage Cooldown: {_attackCooldown} (10 = slow, 1 = fast)");
            Console.WriteLine($"This weapon Cost: {_cost} Coins");
        }
    }
}
