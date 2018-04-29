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

namespace BestandsInvoer
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

        private void FileButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var sourcepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                var myfile = System.IO.Path.Combine(sourcepath, "myfile.txt");
                StreamReader input = File.OpenText(myfile);
                var line = input.ReadLine();

                while (line != null)
                {
                    fileTextBox.AppendText(line);
                    fileTextBox.AppendText(Environment.NewLine);
                    line = input.ReadLine();
                }

                input.Close();
            }
            catch (IOException io)
            {
                MessageBox.Show(io.Message);
            }
        }
    }
}
