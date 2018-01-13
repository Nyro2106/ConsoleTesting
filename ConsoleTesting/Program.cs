using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTesting.Delegates;
using ConsoleTesting.Events;
using ConsoleTesting.People;
using ConsoleTesting.Exceptions;
using ConsoleTesting.Shapes;
using static System.Console;

namespace ConsoleTesting
{
  internal class Program
  {
    private static void Main(string[] args)
    {

      ReadKey();
    }

    private static void TestBarSituation()
    {
      Bar bar = new Bar();
      Person pers1 = new Person() { Name = "Phillip" };
      Person pers2 = new Person() { Name = "TimTom" };
      pers1.GetIn(bar);
      pers2.GetIn(bar);
      bar.SpendRound();

      pers2.GetOut(bar);

      bar.SpendRound();

    }

    public static void TestCalculationDelegate()
    {
      WriteLine("Was soll berechnet werden");
      WriteLine("1-Addieren, 2-Subtrahieren, 3-Multipliziern, 4-Dividieren");
      string type = ReadLine();
      try
      {
        Calculation.Calculate(type, 25, 4);
      }
      catch (Exception ex)
      {
        WriteLine(ex.Message);
      }
    }

    public static int[] ReverseSeq(int n)
    {

      //int[] arr = ReverseSeq(6);

      //for (int i = 0; i < arr.Length; i++)
      //{
      //  WriteLine(arr[i]);
      //}


      int size = n;
      int[] arr = new int[n];
      for (int i = 0; i < n; i++)
      {
        arr[i] = size;
        size--;
      }
      return arr;
    }

    public static void GetChings(int maxPersons)
    {
      int currentChings = 0;
      int[] chingsArr = new int[maxPersons];

      for (int i = 0; i < maxPersons; i++)
      {
        if (i < 2)
        {
          chingsArr[i] = 0;
          continue;
        }
        currentChings += i - 1;
        chingsArr[i] = currentChings;

        WriteLine($"Anzahl Personen {i}, Anzahl klingender Gläser {chingsArr[i]}");
      }
     
    }

    public static string RemoveChar(string s)
    {
      string returnString = "";
      for (int i = 1; i < s.Length - 1; ++i)
        returnString += s[i];

      return returnString;
    }

    //var dishes = Dish.GetDishes();

    //var groupedDishes = from dish in dishes
    //                    orderby dish.Calories descending
    //                    group dish by dish.Calories > 500;

    //foreach (var group in groupedDishes)
    //{
    //  WriteLine(group.Key ? "\nNicer Dicer:" : "\nWer soll davon satt werden :I:");
    //  foreach (var dish in group)
    //  {
    //    WriteLine($"{dish.Calories}kcal\t{dish.Name}");
    //  }
    //}

    private static void Fight()
    {
      Boss epicMob = new Boss("Hogger", 50, 500, 500);
      List<WoWCreature> players = new List<WoWCreature>()
            {
                new Warrior("Leeroy Jenkins", 20, 150, 150),
                new Shaman("Fac3Melt0r", 8, 100, 100, 25),
                new Warrior("Killaxe, the Orc", 80, 500, 500)
            };

      int playersAlive = players.Count;

      WriteLine("Beginne Kampf!");
      WriteLine(((Warrior)players[0]).WarCry);

      while (!epicMob.IsDead && playersAlive > 0)
      {
        foreach (var player in players)
        {
          if (player.IsDead)
          {
            continue;
          }

          WriteLine($"{player.Name} ist dran, er hat noch {player.CurrentHealth} Leben");
          WriteLine(player.Attack(epicMob));

          if (epicMob.CurrentHealth == 0)
          {
            epicMob.IsDead = true;
            break;
          }

          if (player is Shaman)
          {
            WriteLine(((Shaman)player).Heal(player));
          }

          WriteLine(epicMob.Attack(player));

          if (player.CurrentHealth == 0)
          {
            player.IsDead = true;
            playersAlive--;
          }
          WriteLine($"Nächste Runde, {epicMob.Name} hat noch {epicMob.CurrentHealth} Leben");
        }
      }
      if (epicMob.IsDead)
      {
        WriteLine("Gewonnen! Das gibt fetten Loot!");
      }
      else
      {
        WriteLine("Verloren! Buuuh, ihr seid Scheiße!");
      }
    }

    private static void WriteSomeStuff()
    {
      WriteLine("Please write something nice");
      string input = ReadLine();

      if (string.IsNullOrEmpty(input) || input == "Nah :I")
      {
        throw new MyLittleException();
      }
    }

    private static string TextSearch(string inputText, string textToSearch)
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

    private static void StringTeiler(string input, int start, int end)
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