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
using Windows.UI.Notifications;

namespace WPFTesting
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

    private void UxOpenColorPickerButton_Click(object sender, RoutedEventArgs e)
    {
      ColorPicker picker = new ColorPicker();
      picker.Show();
    }

    private void UxOpenLompfOMatButton_Click(object sender, RoutedEventArgs e)
    {
      LompfOMat lompf = new LompfOMat();
      lompf.Show();
    }

    private void UxOpenShortCutsAndCommandsButton_Click(object sender, RoutedEventArgs e)
    {
      ShortCutsAndCommands scac = new ShortCutsAndCommands();
      scac.Show();
    }

    private void UxOpenCryptography_Click(object sender, RoutedEventArgs e)
    {
      CryptoWindow window = new CryptoWindow();
      window.Show();
    }

    private void UxOpenToast_Click(object sender, RoutedEventArgs e)
    {
      var templateContent = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText02);
      templateContent.GetElementsByTagName("text")[0].InnerText = "Ich bin der Oberbumsknecht";
      templateContent.GetElementsByTagName("text")[1].InnerText = "Über alle Arten von bitches";
      ToastNotification notification = new ToastNotification(templateContent);
      ToastNotificationManager.CreateToastNotifier().Show(notification);
    }
  }
}
