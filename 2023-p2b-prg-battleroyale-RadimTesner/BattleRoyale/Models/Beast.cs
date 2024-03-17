using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale.Models
{
    internal class Beast : Enemy
    {
        public Beast(int damage) : base(damage)
        {

        }
        public override void Attack(Enemy enemy)
        {
            enemy.ReceiveDamage(Damage);
            enemy.IsParalyzed = true;
        }
    }
}
