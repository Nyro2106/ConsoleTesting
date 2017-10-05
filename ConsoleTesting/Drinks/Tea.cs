using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.Drinks
{
    class Tea : Drink, IHotDrink
    {
        public int Degree { get; set; }

        public Tea() { }

        public Tea(int degree)
        {
            this.Degree = degree;
        }

        public override string DrinkIt()
        {
            return $"Mmh, köstlicher Tee, er ist ganz frisch, ca {Degree}°";
        }
    }
}
