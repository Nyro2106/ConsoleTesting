using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class CannibalGhost : Ghost
    {
        public CannibalGhost(string name, int size) : base(name, size) { }

        public string Eat(ref Ghost ghost)
        {
            string ghostName = ghost.Name;
            this.Size += ghost.Size;
            ghost = null;
            return Devour(ghostName, this.Size);
        }

        public string Eat(ref SlimeGhost ghost)
        {
            string ghostName = ghost.Name;
            this.Size += ghost.Size;
            ghost = null;
            return Devour(ghostName, this.Size);
        }

        public string Eat(ref CannibalGhost ghost)
        {
            string ghostName = ghost.Name;
            this.Size += ghost.Size;
            ghost = null;
            return Devour(ghostName, this.Size);
        }

        private string Devour(string name, int size)
        {
            return $"{name} wurde gefressen, {this.Name} ist jetzt {this.Size} Geistereinheiten groß";
        }
    }
}
