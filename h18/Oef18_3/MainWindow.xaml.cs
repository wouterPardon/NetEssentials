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

namespace Oef18_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OpenFileDialog openFile;
        private StreamReader reader;
        private string path;
        public MainWindow()
        {
            InitializeComponent();
            openFile = new OpenFileDialog();
            SearchButton.IsEnabled = false;
            
        }

        private void BrowsButton_Click(object sender, RoutedEventArgs e)
        {
            if (openFile.ShowDialog() == true)
            {
                reader = File.OpenText(openFile.FileName);
                path = openFile.FileName;
                SearchButton.IsEnabled = true;
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBox.Text = path + " \n";
            string line;
            try
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(SearchTextBox.Text))
                    {
                        ResultTextBox.Text += line + "\n";
                    }
                }

            }
            catch (FileNotFoundException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                reader?.Close();
            }
        }
    }
}
