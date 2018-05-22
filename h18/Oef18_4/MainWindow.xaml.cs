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

namespace Oef18_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StreamReader readerFile1;
        private StreamReader readerFile2;
        private OpenFileDialog openFile;
        private bool equalsFiles = true;
        public MainWindow()
        {
            InitializeComponent();
            openFile = new OpenFileDialog();
        }

        private void File1Button_Click(object sender, RoutedEventArgs e)
        {
            if (openFile.ShowDialog() == true)
            {
                readerFile1 = File.OpenText(openFile.FileName);
            }
        }

        private void File2Button_Click(object sender, RoutedEventArgs e)
        {
            if (openFile.ShowDialog() == true)
            {
                readerFile2 = File.OpenText(openFile.FileName);
            }
        }

        private void CompareButton_Click(object sender, RoutedEventArgs e)
        {
            if (IsEaqualsFile12())
            {
                MessageBox.Show("Bestanden zijn gelijk");
            }
            else
            {
                MessageBox.Show("Bestanden zijn niet gelijk");
            }
        }

        private bool IsEaqualsFile12()
        {
            string lineFile1, lineFile2;
            string tekstFile1 = "", tekstFile2 = "";
            while ((lineFile1 = readerFile1.ReadLine()) != null)
            {
                    tekstFile1 += lineFile1;
            }
            while ((lineFile2 = readerFile2.ReadLine()) != null)
            {
                tekstFile2 += lineFile2;
            }


            if(tekstFile1 == tekstFile2) return true;

            return false;
        }
    }
}
