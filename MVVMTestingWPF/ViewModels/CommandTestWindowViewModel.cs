using MVVMTestingWPF.Helpers;

namespace MVVMTestingWPF.ViewModels
{
  internal class CommandTestWindowViewModel : PropertyChangedEntity
  {
    public DelegateCommand<string> SayHelloCommand { get; set; }

    private string message;

    public string Message
    {
      get { return message; }
      set
      {
        message = value;
        this.OnPropertyChanged();
        this.SayHelloCommand.RaiseCanExecuteChanged();
      }
    }

    public CommandTestWindowViewModel()
    {
      this.SayHelloCommand = new DelegateCommand<string>
        (
          (s) => this.Message = $"Hallo {this.Message}",
          (s) => !string.IsNullOrEmpty(this.Message)
        );
    }
  }
}