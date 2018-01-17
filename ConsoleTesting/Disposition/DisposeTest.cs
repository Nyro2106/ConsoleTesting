using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.Disposition
{
  class DisposeTest : IDisposable
  {
    public int Number { get; set; } = 4;

    public void Dispose()
    {
      Number = 22;
      Console.WriteLine($"Runter mit der Hose, jetzt gehts zur Dispose Nummer {Number}");
    }
  }
}
