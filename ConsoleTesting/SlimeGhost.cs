using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class SlimeGhost : Ghost
    {
        public SlimeGhost(string name, int size) : base(name, size) { }

        public override string Haunt()
        {
            return $"{base.Haunt()}\nIch schleim dir alles voll du Sau!";
        }
    }
}
