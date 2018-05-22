using System.IO;
using System.Security.Cryptography;
using System.Windows;
using WPFTesting.Crypthography;

namespace WPFTesting
{
  /// <summary>
  /// Interaction logic for Crypto.xaml
  /// </summary>
  public partial class CryptoWindow : Window
  {
    public string EncryptedFilePath { get; set; } = @"C:\users\nyro\desktop\crypt.txt";
    public string EncryptedFileKeyPath { get; set; } = @"C:\users\nyro\desktop\key.txt";
    public string EncryptedFileVectorPath { get; set; } = @"C:\users\nyro\desktop\vector.txt";

    public CryptoWindow()
    {
      InitializeComponent();
    }

    private void UxEncryptButton_Click(object sender, RoutedEventArgs e)
    {
      try
      {
        Encrypt(this.UxTextToEncryptTextBox.Text);
      }
      catch
      {
        MessageBox.Show("Konnte nicht verschlüsselt werden");
      }
    }

    private void UxDecryptButton_Click(object sender, RoutedEventArgs e)
    {
      try
      {
        Decrypt();
      }
      catch
      {
        MessageBox.Show("Konnte nicht entschlüsselt werden");
      }
    }

    private void Encrypt(string textToEncrypt)
    {
      using (RijndaelManaged currentRijndael = new RijndaelManaged())
      {
        currentRijndael.GenerateKey();
        currentRijndael.GenerateIV();

        byte[] encrypted = RijndaelAlgorithm.EncryptStringToBytes(textToEncrypt, currentRijndael.Key, currentRijndael.IV);        

        File.WriteAllBytes(this.EncryptedFilePath, encrypted);
        File.WriteAllBytes(this.EncryptedFileKeyPath, currentRijndael.Key);
        File.WriteAllBytes(this.EncryptedFileVectorPath, currentRijndael.IV);
      }
    }

    private void Decrypt()
    {
      using (RijndaelManaged currentRijndael = new RijndaelManaged())
      {
        byte[] encrypted = File.ReadAllBytes(this.EncryptedFilePath);
        currentRijndael.Key = File.ReadAllBytes(this.EncryptedFileKeyPath);
        currentRijndael.IV = File.ReadAllBytes(this.EncryptedFileVectorPath);

        string decrypted = RijndaelAlgorithm.DecryptStringFromBytes(encrypted, currentRijndael.Key, currentRijndael.IV);

        this.UxDecryptedTextTextBox.Text = decrypted;
      }
    }


  }
}
