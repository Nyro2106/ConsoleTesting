using MVVMTestingWPF.View;
using MVVMTestingWPF.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMTestingWPF
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void UxListBoxWindowButton_Click(object sender, RoutedEventArgs e)
    {
      ListBoxWindow window = new ListBoxWindow();
      window.Show();
    }

    private void UxSliderWindowButton_Click(object sender, RoutedEventArgs e)
    {
      SliderWindow window = new SliderWindow();
      window.Show();
    }

    private void UxMultipleImagesSliderButton_Click(object sender, RoutedEventArgs e)
    {
      MultipleImagesSliderWindow window = new MultipleImagesSliderWindow();
      window.Show();
    }

    private void UxCommandTestWindowButton_Click(object sender, RoutedEventArgs e)
    {
      CommandTestWindow window = new CommandTestWindow();
      window.Show();
    }
  }
}
