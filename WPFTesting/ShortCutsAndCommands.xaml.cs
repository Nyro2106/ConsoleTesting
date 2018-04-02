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

namespace WPFTesting
{
  /// <summary>
  /// Interaction logic for ShortCutsAndCommands.xaml
  /// </summary>
  public partial class ShortCutsAndCommands : Window
  {

    public ShortCutsAndCommands()
    {
      InitializeComponent();
    }

    private static void ClearFields(StackPanel panel)
    {
      foreach (var item in panel.Children)
      {
        if (item is TextBox textBox)
        {
          textBox.Clear();
        }
      }
    }

    private void UxTab1ClearFieldsButton_Click(object sender, RoutedEventArgs e)
    {
      ClearFields(UxTab1StackPanel);
    }

    private void UxTab2ClearFieldsButton_Click(object sender, RoutedEventArgs e)
    {
      ClearFields(UxTab2StackPanel);
    }


  }
}
