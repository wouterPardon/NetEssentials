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

namespace Oef4_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double omtrek;
        double oppervlakte;
        double volume;
        double straal;
        public MainWindow()
        {
            InitializeComponent();


        }

        private void berekenButton_Click(object sender, RoutedEventArgs e)
        {
            straal = Convert.ToDouble(straalTextBox.Text);

            omtrek = 2 * Math.PI * straal;
            oppervlakte = Math.PI * Math.Pow(straal, 2);
            volume = (4 * Math.PI / 3) * Math.Pow(straal, 3);

            omLabel.Content = Convert.ToString(Math.Round(omtrek, 2));
            oppLabel.Content = Convert.ToString(Math.Round(oppervlakte, 2));
            volLabel.Content = $"{volume:0.00}";
        }
    }
}
