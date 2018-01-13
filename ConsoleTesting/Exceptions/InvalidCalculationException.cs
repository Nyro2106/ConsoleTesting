using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.Exceptions
{
  class InvalidCalculationException : Exception
  {
    public override string Message { get;} = "Ungültige Eingabe";
  }
}
