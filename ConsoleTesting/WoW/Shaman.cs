using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class Shaman : WoWCreature, IHealer
    {
        public int Spellpower { get; set; }

        public Shaman(string name, int damage, int currentHealth, int maxHealth, int spellpower) : base(name, damage, currentHealth, maxHealth)
        {
            this.Spellpower = spellpower;
        }


        public string Heal(WoWCreature creature)
        {
            CurrentSpellpower = Rand.Next(Spellpower / 2, Spellpower);
            if (creature.CurrentHealth + this.CurrentSpellpower < creature.MaxHealth)
            {
                creature.CurrentHealth += CurrentSpellpower;
                return $"{this.Name} heilt.\n{creature.Name} wurde um {this.CurrentSpellpower} geheilt\n";
            }
            else
            {
                creature.CurrentHealth = creature.MaxHealth;
                return $"{creature.Name} wurde vollgeheilt";
            }
        }
    }
}
