using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.Extensions
{
  public static class ExtensionMethods
  {
    public static int DaysSinceMillenium(this DateTime val)
    {
      return val.Subtract(new DateTime(2000, 1, 1)).Days;
    }
  }
}
