using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting.Events
{
  class Bar
  {
    public event EventHandler SpendARound;

    public void SpendRound()
    {
      this.SpendARound?.Invoke(this, EventArgs.Empty);
    }
  }
}
