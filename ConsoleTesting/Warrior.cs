using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class Warrior : WoWCreature
    {
        public string WarCry { get; set; } = "LEEEEEEERRROYYY JEENNKIINNSSS!";

        public Warrior(string name, int damage, int currentHealth, int maxHealth) : base(name, damage, currentHealth, maxHealth)
        {
        }
    }
}
