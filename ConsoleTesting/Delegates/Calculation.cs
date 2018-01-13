using ConsoleTesting.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.Delegates
{

  static class Calculation
  {
    delegate float CalculationHandler(float a, float b);

    internal static void Calculate(string input, float firstNumber, float secondNumber)
    {
      CalculationHandler calcy;
      if (int.TryParse(input, out int calculationType))
      {
        switch (calculationType)
        {
          case 1:
            calcy = AddMethod;
            break;
          case 2:
            calcy = SubtractMethod;
            break;
          case 3:
            calcy = MultiplyMethod;
            break;
          case 4:
            calcy = DivisionMethod;
            break;
          default:
            calcy = null;
            break;
        }
        if (calcy != null)
        {
          ExecuteCalculation(calcy, firstNumber, secondNumber);
          return;
        }
      }
      throw new InvalidCalculationException();
    }

    private static void ExecuteCalculation(CalculationHandler calcy, float firstNumber, float secondNumber)
    {
      Console.WriteLine($"Berechnung für {firstNumber} und {secondNumber} wird durchgeführt");
      float result = calcy(firstNumber, secondNumber);
      Console.WriteLine($"Das Ergebnis ist {result}");
    }

    private static float DivisionMethod(float a, float b)
    {
      if (b != 0)
      {
        return a / b;
      }
      return 0;
    }

    private static float MultiplyMethod(float a, float b)
    {
      return a * b;
    }

    private static float SubtractMethod(float a, float b)
    {
      return a - b;
    }

    private static float AddMethod(float a, float b)
    {
      return a + b;
    }
  }
}
