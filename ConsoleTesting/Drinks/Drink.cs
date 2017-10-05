using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.Drinks
{
    abstract class Drink
    {
        public abstract string DrinkIt();

        //        IHotDrink[] hotDrinks = new IHotDrink[]
        //{
        //                new Coffee { Degree = 80, Caffeine = 1.25f },
        //                new Tea { Degree = 88 }
        //};

        //        ICaffeine[] wakeUpDrinks = new ICaffeine[]
        //        {
        //                new Coffee { Degree = 92, Caffeine = 2.22f },
        //                new Cola { Caffeine = 104 }
        //        };

        //            foreach (var drink in hotDrinks)
        //            {
        //                WriteLine($"Das ist {drink.GetType().Name}, Temperatur: {drink.Degree}");
        //    }

        //            foreach (var drink in wakeUpDrinks)
        //            {
        //                WriteLine($"Das ist {drink.GetType().Name}, Koffein: {drink.Caffeine}");
        //}
    }
}
