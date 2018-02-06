using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.Restaurant
{
  public enum DishType
  {
    Cold,
    Warm
  }

  [Serializable]
  public class Dish
  {
    public string Name { get; set; }
    public DishType Type { get; set; }
  }
}
