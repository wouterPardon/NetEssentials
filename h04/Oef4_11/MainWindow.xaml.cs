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

namespace Oef4_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int getal;
        StringBuilder getallen = new StringBuilder();
        int rest;
        string result;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, RoutedEventArgs e)
        {
            getal = Convert.ToInt32(getalTextbox.Text);

            while(getal > 1){
                rest = getal % 2;
                getal /= 2;
                getallen.Append(rest);
            }

            getallen.Append(1);

            char[] arr = getallen.ToString().ToCharArray();

            Array.Reverse(arr);
            result = new string(arr);

            resultLabel.Content = result;

            result = "";
            getallen = new StringBuilder();
        }
    }
}
