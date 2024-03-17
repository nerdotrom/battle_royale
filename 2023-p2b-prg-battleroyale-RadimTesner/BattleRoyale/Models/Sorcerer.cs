using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale.Models
{
    internal class Sorcerer : Enemy
    {
        int Mana = 4;
        int Spell = 20;
        public Sorcerer(int damage) : base(damage)
        {

        }

        public override void Attack(Enemy enemy)
        {
            if (Mana != 0)
            {
                enemy.ReceiveDamage(Damage + Spell);
                Mana--;
            }
            else
            {
                enemy.ReceiveDamage(Damage);
            }
        }
        public override string ToString()
        {
            return "Mana: " + Mana + "; " + base.ToString();
        }
    }
}
