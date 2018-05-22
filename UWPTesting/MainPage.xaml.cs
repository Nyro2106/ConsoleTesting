using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPTesting
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

    private async void UxHelloButton_Click(object sender, RoutedEventArgs e)
    {
      MessageDialog dialog = new MessageDialog("Hai Schatz :3!", "<3");
      await dialog.ShowAsync();
    }

    private void UxOpenResizablePageButton_Click(object sender, RoutedEventArgs e)
    {
      Frame.Navigate(typeof(ResizablePage));
    }

    private void UxOpenAppLayoutButton_Click(object sender, RoutedEventArgs e)
    {
      Frame.Navigate(typeof(AppLayout));
    }

    private async void UxStartFancySoundButton_Click(object sender, RoutedEventArgs e)
    {      
      string text2 = " What does the fox say? Ringdingdingdingding ding dingering, heiti heiti heiti hoi.";
      string text3 = "Zupf";
      MediaElement mediaElement = new MediaElement();
      var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
      Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(text3);
      mediaElement.SetSource(stream, stream.ContentType);
      mediaElement.Play();
    }

    private async void UxStartFancySoundButton2_Click(object sender, RoutedEventArgs e)
    {
      string text3 = "Stops";
      MediaElement mediaElement = new MediaElement();
      var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
      Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(text3);
      mediaElement.SetSource(stream, stream.ContentType);
      mediaElement.Play();
    }
  }
}
