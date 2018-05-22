using MVVMTesting.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTesting.Models
{
  class Person : PropertyChangedEntity
  {
    private string _name;
    private int _age;
    private string _email;


    public string Name
    {
      get => _name;
      set
      {
        _name = value;
        this.OnPropertyChanged();
        this.OnPropertyChanged(nameof(this.FullInfo));
      }
    }
    public int Age
    {
      get => _age;
      set
      {
        _age = value;
        this.OnPropertyChanged();
      }
    }
    public string Email
    {
      get => _email;
      set
      {
        _email = value;
        this.OnPropertyChanged();
        this.OnPropertyChanged(nameof(this.FullInfo));
      }
    }
    public string FullInfo => $"{Name} ({Email})";
  }
}
