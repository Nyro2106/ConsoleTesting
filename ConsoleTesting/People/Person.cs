using System;
using ConsoleTesting.Events;

namespace ConsoleTesting.People
{
  internal class Person : IFriend, IFoe
  {
    public string Name { get; set; }

    public void GetIn(Bar bar)
    {
      bar.SpendARound += GetARound;
    }

    public void GetOut(Bar bar)
    {
      bar.SpendARound -= GetARound;
    }

    private void GetARound(object sender, EventArgs e)
    {
      Console.WriteLine($"{this.Name} freut sich über ein kaltes Getränk");
    }

    string IFriend.GetCalled()
    {
      return "Jau, du bist ne coole Arschsau";
    }

    string IFoe.GetCalled()
    {
      return "You da Foe, Foe!!";
    }
  }
}