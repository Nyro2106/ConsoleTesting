using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Net;
using ConsoleTesting.Shapes;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {




            ReadKey();
        }




        static string TextSearch(string inputText, string textToSearch)
        {
            int counter = 0;
            int indexOfFoundText = 0;
            
            for (int i = 0; i < inputText.Length; i++)
            {
                indexOfFoundText = i;
                try
                {
                    for (int j = 0; j < textToSearch.Length; j++)
                    {
                        if (inputText[i + j] == textToSearch[j])
                        {
                            counter++;
                            if (counter == textToSearch.Length)
                            {
                                return $"Der gesuchte Text wurde gefunden, an Position {indexOfFoundText}";
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                catch
                {
                    return "Der gesuchte Text wurde nicht gefunden";
                }
                counter = 0;
            }
            return "Der gesuchte Text wurde nicht gefunden";
        }

        static void StringTeiler(string input, int start, int end)
        {
            string temp = "";
            for (int i = start; i < end; i++)
            {
                temp += input[i];
            }
            WriteLine(temp);
        }

        private static void GetPrime(int limit)
        {
            bool isPrime;
            for (int i = 2; i < limit; i++)
            {
                isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    WriteLine(i);
                }
            }
        }
    }
}
