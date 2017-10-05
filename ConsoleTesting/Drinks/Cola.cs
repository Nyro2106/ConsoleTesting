using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.Drinks
{
    class Cola : Drink, ICaffeine
    {
        public float Caffeine { get; set; }

        public Cola() { }

        public Cola(float caffeine)
        {
            this.Caffeine = caffeine;
        }

        public override string DrinkIt()
        {
            return $"Lecker Cola, sie enthält viel Coffeine. {Caffeine}mg/l";
        }
    }
}
