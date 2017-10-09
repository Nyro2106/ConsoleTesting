using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class Boss : WoWCreature
    {
        public Boss(string name, int damage, int currentHealth, int maxHealth) : base(name, damage, currentHealth, maxHealth)
        {
        }
    }
}
