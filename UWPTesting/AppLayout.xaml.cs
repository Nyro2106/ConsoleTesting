using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPTesting
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class AppLayout : Page
  {
    public AppLayout()
    {
      this.InitializeComponent();
    }

    private void UxBackToStart_Click(object sender, RoutedEventArgs e)
    {
      Frame.Navigate(typeof(MainPage));
    }

    private async void UxSaveButton_Click(object sender, RoutedEventArgs e)
    {
      StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
      StorageFile sampleFile = await storageFolder.CreateFileAsync("sample.txt", CreationCollisionOption.ReplaceExisting);
      await FileIO.WriteTextAsync(sampleFile, "Tis some sick text yo");
    }
  }
}
