using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.People
{
  class Human
  {
    public string Gender { get; set; }

    public int Cigarettes { get; set; }

    public int Vegetables { get; set; }

    public int BasicLifeExpectancy { get; set; }

    public int LifeExpectancy { get; set; }

    internal void CalculateLifeExpectancy()
    {      
      if (this.Gender.Equals("male"))
      {
        this.BasicLifeExpectancy -= 5;
      }
      this.LifeExpectancy = BasicLifeExpectancy - (this.Cigarettes / 2) + this.Vegetables;      
    }

    internal string GetInfo()
    {
      return $"{this.LifeExpectancy} Jahre. Und keinen Tag mehr";
    }
  }
}
