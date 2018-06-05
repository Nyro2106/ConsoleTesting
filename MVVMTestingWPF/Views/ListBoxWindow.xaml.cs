using MVVMTestingWPF.Models;
using MVVMTestingWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVVMTestingWPF.View
{
  /// <summary>
  /// Interaction logic for ListBoxWindow.xaml
  /// </summary>
  public partial class ListBoxWindow : Window
  {
    public ListBoxWindow()
    {
      InitializeComponent();
    }

    private void UxPersonsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      (this.UxMainGrid.DataContext as ListBoxWindowViewModel).CurrentPerson = e.AddedItems[0] as Person;
    }
  }
}
