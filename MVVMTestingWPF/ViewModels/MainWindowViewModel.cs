using MVVMTestingWPF.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTestingWPF.ViewModels
{
  class MainWindowViewModel
  {
    public Person Person { get; set; }

    public MainWindowViewModel()
    {
      this.Person = new Person();
      this.Person.Name = "";
      this.Person.Age = 117;
      this.Person.Email = "hodi@skyhodies.de";
      //this.GetName();
    }

    //public async void GetName()
    //{      
      //await Task.Run(() => this.Person.Name = File.ReadAllText(@"C:\users\nyro\desktop\test.txt"));
    //}
  }
}
