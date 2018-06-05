using MVVMTestingWPF.Helpers;
using MVVMTestingWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTestingWPF.ViewModels
{
  class ListBoxWindowViewModel : PropertyChangedEntity
  {
    public ObservableCollection<Person> Persons { get; set; }

    public ListBoxWindowViewModel()
    {
      this.Persons = new ObservableCollection<Person>()
      {
        new Person { Name = "Tim", Age = 16, Email = "Tim@tim.de" },
        new Person { Name = "Tom", Age = 44, Email = "Tom@tim.de" },
        new Person { Name = "Tam", Age = 23, Email = "Tam@tim.de" },
        new Person { Name = "Schnippi", Age = 63, Email = "Schnippi@tim.de" },
        new Person { Name = "Phillip", Age = 24, Email = "Phillip@tim.de" },
        new Person { Name = "Plontzi", Age = 33, Email = "Plontzi@tim.de" },
        new Person { Name = "Haumichblau", Age = 22, Email = "Haumichblau@tim.de" },
        new Person { Name = "Jesus", Age = 53, Email = "Jesus@tim.de" },
        new Person { Name = "Bleppi", Age = 43, Email = "Bleppi@tim.de" },
      };
    }

    private Person currentPerson;

    public Person CurrentPerson
    {
      get { return currentPerson; }
      set { currentPerson = value; this.OnPropertyChanged(); }
    }


  }
}
