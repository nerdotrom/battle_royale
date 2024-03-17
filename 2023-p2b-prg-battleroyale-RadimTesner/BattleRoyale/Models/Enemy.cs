using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyale.Models
{
    internal class Enemy
    {
        protected int HP;
        public int Damage;
        public bool IsParalyzed = false;

        public Enemy( int damage = 10)
        {
            HP = 100;
            Damage = damage;
        }

        public Enemy PickOpponent(Enemy[] combatants)
        {

            while (true)
            {
                int random = new Random().Next(0, combatants.Length);
                if (combatants[random].IsAlive)
                {
                    return combatants[random];
                }
            }
        }

        public virtual int ReceiveDamage(int damage)
        {
            HP -= damage;
            if (HP < 0) {  HP = 0; }
            return HP;
        }

        public virtual void Attack(Enemy enemy) 
        { 
            if (!IsParalyzed) 
            {
                enemy.ReceiveDamage(Damage);
            }
        }
        public bool IsAlive
        {
            get
            {
                if (HP > 0) { return true; }
                return false;
            }
        }
        public void RemoveParalyzed()
        {
            IsParalyzed = false;
        }
        public override string ToString()
        {
            return "Damage: " + Damage + "; HP: " + HP + "; Paralyzed: " + IsParalyzed; 
        }
    }
}
