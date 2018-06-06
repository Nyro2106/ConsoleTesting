using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMTestingWPF.Helpers
{
  class DelegateCommand<T> : ICommand
  {
    public event EventHandler CanExecuteChanged;

    Predicate<T> CanExecuteHandler { get; set; }
    Action<T> ExecuteHandler { get; set; }

    public DelegateCommand(Action<T> executeHandler, Predicate<T> canExecuteHandler)
    {
      this.CanExecuteHandler = canExecuteHandler;
      this.ExecuteHandler = executeHandler ?? throw new ArgumentNullException(nameof(executeHandler), "Please specify the command, bro");
    }
    
    public void RaiseCanExecuteChanged()
    {
      this.CanExecuteChanged?.Invoke(this, null);
    }

    public bool CanExecute(object parameter)
    {
      return this.CanExecuteHandler == null || this.CanExecuteHandler((T)parameter) == true;
    }

    public void Execute(object parameter)
    {
      this.ExecuteHandler((T)parameter);
    }
  }
}
