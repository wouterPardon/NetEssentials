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

namespace BestandUitvoer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string destination = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string newFile = System.IO.Path.Combine(destination, "myfile.txt");

            StreamWriter stream = File.CreateText(newFile);
            stream.WriteLine("This file");
            stream.WriteLine("Contains");
            stream.WriteLine("3 lines");

            stream.Close();
        }
    }
}
