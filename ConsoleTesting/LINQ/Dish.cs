using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.LinqStuff
{
    class Dish
    {
        public string Name { get; set; }
        public int Calories { get; set; }

        public static Dish[] GetDishes()
        {
            Dish[] tempDishes = new Dish[]
            {
                new Dish() { Name = "Broccoli gratiniert", Calories = 320},
                new Dish() { Name = "Nudelsalat", Calories = 506},
                new Dish() { Name = "Mozzarella mit Tomaten", Calories = 280},
                new Dish() { Name = "Schnitzel mit Pommes", Calories = 840},
                new Dish() { Name = "Gefüllte Paprika", Calories = 250},
                new Dish() { Name = "Spaghetti mit Tomatensoße", Calories = 378},
                new Dish() { Name = "Chinesische Nudeln", Calories = 520},
                new Dish() { Name = "Pizza", Calories = 800},
            };
            return tempDishes;
        }
    }
}
