using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTesting.Helpers
{
  class PropertyChangedEntity : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;
    protected internal void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
      this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
