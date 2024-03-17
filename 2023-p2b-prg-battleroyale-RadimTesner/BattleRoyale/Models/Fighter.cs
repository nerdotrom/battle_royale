using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale.Models
{
    internal class Fighter : Enemy
    {
        string Name;
        public Fighter(string name, int damage) : base(damage)
        {
            Name = name;
        }
        public override string ToString()
        {
            return"Name: " + Name + "; " + base.ToString();
        }
    }
}
