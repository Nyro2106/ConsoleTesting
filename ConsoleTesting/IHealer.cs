using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    interface IHealer
    {
        int Spellpower { get; set; }
        string Heal(WoWCreature creature);
    }
}
