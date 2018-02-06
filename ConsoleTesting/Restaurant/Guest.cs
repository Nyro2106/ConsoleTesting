using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.Restaurant
{
  [Serializable]
   public class Guest
  {
    public string Name { get; set; }
    public Dish[] FavoriteDishes { get; set; }
  }
}
