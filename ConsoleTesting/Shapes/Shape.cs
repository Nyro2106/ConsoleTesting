using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.Shapes
{
    abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ConsoleColor Color { get; set; }

        public abstract string Draw();
    }
}
