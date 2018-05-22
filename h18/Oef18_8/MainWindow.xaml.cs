using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;
using System.Windows.Forms;
namespace Oef18_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FolderBrowserDialog folderBrowser;
        private string[] allFiles;
        private StreamReader reader;
        public MainWindow()
        {
            InitializeComponent();
            folderBrowser = new FolderBrowserDialog();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string line;
            ResultTextBlock.Text = "";
            for (int i = 0; i < allFiles.Length; i++)
            {
                reader = File.OpenText(allFiles[i]);
                ResultTextBlock.Text += allFiles[i] + "\n";
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(SearchTextBox.Text))
                    {
                        ResultTextBlock.Text += line + "\n";
                    }
                }
            }
        }

        private void BrouwseWutton_Click(object sender, RoutedEventArgs e)
        {
            folderBrowser.ShowDialog();
            FolderLabel.Content = folderBrowser.SelectedPath;
            allFiles = Directory.GetFiles(folderBrowser.SelectedPath, "*.txt");
        }
    }
}
