using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class Point
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point() : this(0, 0, 0) { }

        public Point(int x) : this(x, 0, 0)
        {
            this.X = x;
        }

        public Point(int x, int y) : this(x, y, 0)
        {
            this.X = x;
            this.Y = y;
        }

        public Point(int x = 0, int y = 0, int z = 0, string name = "Standardwert")
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Name = name;
        }
    }
}
