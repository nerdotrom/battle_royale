using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale.Models
{
    internal class Knight : Fighter
    {
        int Armor = 2;
        public Knight(string name, int damage) : base(name, damage)
        {

        }
        public override int ReceiveDamage(int damage)
        {
            damage -= Armor;
            HP -= damage;
            if (HP < 0) { HP = 0; }
            return HP;
        }
        public override string ToString()
        {
            return "Armor: " + Armor + "; " + base.ToString();
        }
    }
}
