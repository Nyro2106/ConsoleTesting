using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.People
{
    class Person : IFriend, IFoe
    {
        string IFriend.GetCalled()
        {
            return "Jau, du bist ne coole Arschsau";
        }

        string IFoe.GetCalled()
        {
            return "You da Foe, Foe!'!";
        }
    }
}
