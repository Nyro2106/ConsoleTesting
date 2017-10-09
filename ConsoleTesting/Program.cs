using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Net;
using ConsoleTesting.Shapes;
using ConsoleTesting.Drinks;
using System.Diagnostics;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            Dish[] dishes = Dish.GetDishes();

            var groupedDishes = from dish in dishes
                                orderby dish.Calories descending
                                group dish by dish.Calories > 500;
                               
                                

            foreach (var group in groupedDishes)
            {
                WriteLine(group.Key ? "\nNicer Dicer:" : "\nWer soll davon satt werden :I:");
                foreach (var dish in group)
                {
                    WriteLine($"{dish.Calories}kcal\t{dish.Name}");
                }
            }





            ReadKey();
        }

        static void Fight()
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

        static void WriteSomeStuff()
        {
            WriteLine("Please write something nice");
            string input = ReadLine();

            if (string.IsNullOrEmpty(input) || input == "Nah :I")
            {
                throw new MyLittleException();
            }
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
