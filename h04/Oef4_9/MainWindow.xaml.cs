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

namespace Oef4_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double bedrag;
        double[] munten = { 200, 100, 50, 20, 10, 5, 2, 1};
        int[] aantallen;
        StringBuilder aant = new StringBuilder();
        public MainWindow()
        {
            InitializeComponent();

            aantallen = new int[8];
        }

        private void berekenLabel_Click(object sender, RoutedEventArgs e)
        {
            bedrag = Convert.ToDouble(bedragTexbox.Text);
            

            while (bedrag > 0) {
                for (int i = 0; i < munten.Length; i++) {
                    while (bedrag - munten[i] >= 0) {
                        aantallen[i]++;
                        bedrag -= munten[i];
                    }
                }
            }

            foreach(int aantal in aantallen) {

                aant.Append(aantal);
            }

            uitkomstLabel.Content = aant;

        }
    }
}
