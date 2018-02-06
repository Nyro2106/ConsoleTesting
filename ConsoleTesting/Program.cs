using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTesting.Delegates;
using ConsoleTesting.Events;
using ConsoleTesting.People;
using ConsoleTesting.Exceptions;
using ConsoleTesting.Shapes;
using static System.Console;
using ConsoleTesting.Extensions;
using System.Diagnostics;
using System.Reflection;
using System.IO;
using ConsoleTesting.Disposition;
using ConsoleTesting.Serialization;
using ConsoleTesting.Restaurant;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;

namespace ConsoleTesting
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      

      ReadKey();
    }

    private static void RestaurantTest()
    {
      Guest[] guests = new Guest[]
      {
        new Guest { Name = "Schrödiboie", FavoriteDishes = new Dish[]
        {
          new Dish() { Name = "Pommes", Type = DishType.Warm },
          new Dish() { Name = "Schnitzel", Type = DishType.Warm}
        }
        },
        new Guest { Name = "Schrödies Katze", FavoriteDishes = new Dish[]
        {
          new Dish() { Name = "Katzenfutter, duh", Type = DishType.Cold }
        }
        }
      };

      string path = @"C:\users\nyro\desktop\test.txt";

      //Binär-Serialisiert
      //BinaryFormatter formatter = new BinaryFormatter();
      //using (Stream stream = File.OpenWrite(path))
      //{
      //  formatter.Serialize(stream, guests);
      //}

      //Binär-Deserialisiert
      //BinaryFormatter formatter = new BinaryFormatter();
      //using (Stream stream = File.OpenRead(path))
      //{
      //  Guest[] deserializedGuests = (Guest[])formatter.Deserialize(stream);
      //}


      //XML-Serialisiert
      //XmlSerializer serializer = new XmlSerializer(typeof(Guest[]));
      //using (Stream stream = File.OpenWrite(path))
      //{
      //  serializer.Serialize(stream, guests);
      //}

      //XML-Deserialisiert
      //XmlSerializer serializer = new XmlSerializer(typeof(Guest[]));
      //using (Stream stream = File.OpenRead(path))
      //{
      //  Guest[] deserializedGuests = (Guest[])serializer.Deserialize(stream);
      //}

      //JSON-Serialisiert
      //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Guest[]));
      //using (Stream stream = File.OpenWrite(path))
      //{
      //  serializer.WriteObject(stream, guests);
      //}

      //JSON-Deserialisiert
      //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Guest[]));
      //using (Stream stream = File.OpenRead(path))
      //{
      //  Guest[] deserializedGuests = (Guest[])serializer.ReadObject(stream);
      //}

    }

    private static void SerializationTestLoad()
    {
      string path = @"C:\users\nyro\desktop\test.txt";
      SerializablePerson person = new SerializablePerson();

      person = SerializablePerson.Load(path);

      WriteLine($"Des isch der {person.Name}, der isch {person.Age} Jahre alt.");
    }

    private static void SerializationTestSave()
    {
      string path = @"C:\users\nyro\desktop\test.txt";
      SerializablePerson person = new SerializablePerson() { Name = "Hans Wurst", Age = 66 };

      person.Save(path);
    }

    private static void TestDispose()
    {
      try
      {
        using (DisposeTest dispose = new DisposeTest())
        {
          WriteLine(dispose.Number);
          throw new Exception();
          WriteLine("Ich bin dein using, brudah");
        }
      }
      catch (Exception)
      {
        WriteLine("Da ist sie, die Ex-Ception");
      }
    }

    private static void TestSetCreationTimeOnFile()
    {
      string directory = @"C:\users\nyro\desktop\";
      string fileName = $@"{directory}\sum Data.txt";
      File.AppendAllText(fileName, "Text");
      File.SetCreationTime(fileName, new DateTime(1671, 12, 04, 21, 54, 31));
      File.SetLastWriteTime(fileName, new DateTime(1672, 03, 01, 11, 25, 27));
      File.SetLastAccessTime(fileName, new DateTime(1672, 03, 01, 11, 25, 27));
      WriteLine("File created");
    }

    private static void TestGetDriveInfo()
    {
      DriveInfo[] drives = DriveInfo.GetDrives();
      double giga = 1024 * 1024 * 1024;
      foreach (var drive in drives)
      {
        if (drive.IsReady)
        {
          WriteLine($"Name: {drive.Name}\n" +
          $"Typ: {drive.DriveType}\n" +
          $"Freier Speicher: {(drive.AvailableFreeSpace / giga).ToString("0.00")} Gb\n" +
          $"Gesamtgröße: {(drive.TotalSize / giga).ToString("0.00")} Gb\n" +
          $"Wurzeldirektion: {drive.RootDirectory}\n" +
          $"Label: {drive.VolumeLabel}\n");
          WriteLine(); 
        }
      }
    }

    private static void TestGetAllEntryExtensions()
    {
      string directory = @"D:\Games\Star Wars-The Old Republic";
      DirectoryInfo directoryInfo = new DirectoryInfo(directory);
      List<string> extensions = new List<string>();
      foreach (var file in directoryInfo.GetFiles())
      {
        if (!extensions.Contains(file.Extension.ToLower()))
        {
          extensions.Add(file.Extension);
          WriteLine($"Gefundene Endung: {file.Extension}");
        }
      }
    }

    private static void TestDiary()
    {
      string directory = @"C:\users\nyro\desktop\";
      string fileName = $@"{directory}\diary.txt";
      WriteLine($"Letzte Änderung {File.GetLastWriteTime(fileName)}");
      WriteLine("Bitte neuen Eintrag eingeben:");
      string input = ReadLine();
      string newEntry = $"[{DateTime.Now}] {input}";

      if (File.Exists(fileName))
      {
        WriteLine("Bisher enthaltener Text:");
        string[] existingText = File.ReadAllLines(fileName);
        foreach (var line in existingText)
        {
          WriteLine(line);
        }
      }
      WriteLine("=====================");
      WriteLine("Neu hinzugefügter Text:");
      if (!Directory.Exists(directory))
      {
        Directory.CreateDirectory(directory);
      }
      
      File.AppendAllText(fileName, Environment.NewLine + newEntry);
      WriteLine(newEntry);
      WriteLine("=====================");
    }

    private static void TestWriteText()
    {
      string path = @"C:\users\nyro\desktop\test.txt";
      string stuffToWrite = "Und hier kommt noch mehr Scheiß yeah!";

      File.AppendAllText(path, stuffToWrite);

      WriteLine(File.ReadAllText(path));
    }

    private static void TestAnalyzePerson()
    {
      Person person = new Person();
      person.FirstName = "Hans";
      person.LastName = "Hinterlader";

      Type personType = person.GetType();
      WriteLine($"Typ: {personType.Name}");

      PropertyInfo[] properties = personType.GetProperties();

      foreach (var property in properties)
      {
        WriteLine($"Eigentschaft: {property.Name} - Wert: {property.GetValue(person)}");
      }

      MethodInfo fullNameMethod = personType.GetMethod("GetFullName");
      WriteLine($"Methode {fullNameMethod.Name} aufgerufen ergibt: {fullNameMethod.Invoke(person, null)}");
    }

    [Conditional("DEBUG")]
    private static void TestJustADebugCall()
    {
      WriteLine("You only see me when you deeeeeebug");
    }

    [Obsolete("Tis is ze obsolete stuff")]
    private static void TestSomeObsoleteStuff()
    {
      WriteLine("Pretty old guy, for a white fly.. oder so :I");
    }

    private static void TestLINQOrderByReverse()
    {
      int[] numbers = new int[] { 0, 2, 6, 2, 4, 5, 6, 2, 11, 22, 3, 8, 7, 6, 3, 2, 4 };

      var sortedNumbers = numbers.OrderBy(n => n);
      var reversedSortedNumbers = sortedNumbers.Reverse();

      foreach (var number in sortedNumbers)
      {
        WriteLine(number);
      }

      foreach (var number in reversedSortedNumbers)
      {
        WriteLine(number);
      }
    }

    private static void TestLINQSkipTakeWhile()
    {
      int[] numbers = new int[] { 0, 2, 6, 2, 4, 5, 6, 2, 11, 22, 3, 8, 7, 6, 3, 2, 4 };
      var evenNumbers = numbers.Skip(1).TakeWhile(n => n % 2 == 0);
      foreach (var number in evenNumbers)
      {
        WriteLine(number);
      }
    }

    private static void TestFunc()
    {
      string first = ReadLine();
      string last = ReadLine();

      Func<string, string, string> GetFullName = (firstName, lastName) => firstName + " " + lastName;

      WriteLine(GetFullName(first, last));
    }

    private static void TestLambda()
    {
      string[] stuff = new string[] { "EinZeug", "ZweiZeug", "DreiZeug" };
      string input = Console.ReadLine();
      var lambdaBoi = stuff.Where(item => item.ToLower().Contains($"{input}"));

      WriteLine(lambdaBoi.FirstOrDefault());
    }

    private static void TestExtensionMethod()
    {
      DateTime dateTime = DateTime.Now;
      int daysSinceMillenium = dateTime.DaysSinceMillenium();
      WriteLine(daysSinceMillenium);
    }

    private static void TestBarSituation()
    {
      Bar bar = new Bar();
      Person pers1 = new Person() { FirstName = "Phillip" };
      Person pers2 = new Person() { FirstName = "TimTom" };
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

    public static int[] TestReverseSeq(int n)
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

    public static void TestGetChings(int maxPersons)
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

    public static string TestRemoveChar(string s)
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

    private static void TestFight()
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

    private static void TestWriteSomeStuff()
    {
      WriteLine("Please write something nice");
      string input = ReadLine();

      if (string.IsNullOrEmpty(input) || input == "Nah :I")
      {
        throw new MyLittleException();
      }
    }

    private static string TestTextSearch(string inputText, string textToSearch)
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

    private static void TestStringTeiler(string input, int start, int end)
    {
      string temp = "";
      for (int i = start; i < end; i++)
      {
        temp += input[i];
      }
      WriteLine(temp);
    }

    private static void TestGetPrime(int limit)
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