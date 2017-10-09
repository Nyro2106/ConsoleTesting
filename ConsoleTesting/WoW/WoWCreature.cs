using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public abstract class WoWCreature
    {
        protected Random Rand { get; set; } = new Random();
        public string Name { get; set; }
        public int Damage { get; set; }
        public int CurrentDmg { get; set; }
        public int CurrentSpellpower { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public bool IsDead { get; set; } = false;

        public WoWCreature(string name, int damage, int currentHealth, int maxHealth)
        {
            this.Name = name;
            this.Damage = damage;
            this.CurrentHealth = currentHealth;
            this.MaxHealth = maxHealth;
        }

        public string Attack(WoWCreature creature)
        {
            this.CurrentDmg = Rand.Next(Damage / 2, Damage);
            if (creature.CurrentHealth - this.CurrentDmg > 0)
            {
                creature.CurrentHealth -= this.CurrentDmg;
                return $"{this.Name} greift an.\n{creature.Name} erleidet {this.CurrentDmg} Schaden\n";
            }
            else
            {
                creature.CurrentHealth = 0;
                creature.IsDead = true;
                return $"{this.Name} verursacht {this.CurrentDmg} Schaden.\n{creature.Name} wurde besiegt\n";
            }
        }
    }
}
