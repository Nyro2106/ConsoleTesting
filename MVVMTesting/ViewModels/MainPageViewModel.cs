using MVVMTesting.Models;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace MVVMTesting.ViewModels
{
  class MainPageViewModel
  {
    public Person Person { get; set; }

    public MainPageViewModel()
    {
      this.Person = new Person();
      this.Person.Name = "";
      this.Person.Age = 117;
      this.Person.Email = "hodi@skyhodies.de";
      //this.GetName();
    }

    //public async void GetName()
    //{
    //  await Task.Run(() => this.Person.Name = File.ReadAllText(@"C:\users\nyro\desktop\test.txt"));      

    //}        
    
  }
}
