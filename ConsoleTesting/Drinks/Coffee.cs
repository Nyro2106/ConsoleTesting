using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.Drinks
{
    class Coffee : Drink, IHotDrink, ICaffeine
    {
        public float Caffeine { get; set; }
        public int Degree { get; set; }

        public Coffee () { }

        public Coffee(int degree, float caffeine)
        {
            this.Degree = degree;
            this.Caffeine = caffeine;
        }

        public override string DrinkIt()
        {
            return $"Mmh, köstlicher Kaffe, er ist ganz frisch, ca {Degree}° heiß\nund Koffein enthält er auch." +
                $" {Caffeine}mg/l";
        }

    }
}
