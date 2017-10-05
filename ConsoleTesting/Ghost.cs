using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class Ghost
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public Ghost(string name, int size)
        {
            this.Name = name;
            this.Size = size;
        }

        public string GhostInfo()
        {
            return $"Das ist {this.Name}, er ist {this.Size} Geistereinheiten groß";
        }

        public virtual string Haunt()
        {
            return $"Buh, Miststück! Ich bin {this.Name}";
        }
    }
}
