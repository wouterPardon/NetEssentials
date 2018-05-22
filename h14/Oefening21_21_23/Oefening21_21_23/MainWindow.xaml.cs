using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Oefening21_21_23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Vak vak1;
        private Vak vak2;
        private Vak vak3;
        private Vak[] arr = new Vak[1000];
        private Dictionary<string, Vak> dictionary = new Dictionary<string, Vak>();
        private List<Vak> list = new List<Vak>();
        Stopwatch stopwatch = new Stopwatch();
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 1000; i++)
            {
                vak1 = new Vak(i + "", "docent", 2);
                arr[i] = vak1;
                dictionary.Add(vak1.Naam, vak1);
                list.Add(vak1);
            }
        }

        private void ZoekenArrButton_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Start();
            ResultTextBox.Clear();
            int i = 0;
            bool found = false;
            while (!found && i < 1000)
            {
                if (arr[i].Naam == ZoekTextBox.Text)
                {
                    ResultTextBox.AppendText("Vakgegevens voor " + arr[i].Naam + "\n");
                    ResultTextBox.AppendText("Naam docent " + arr[i].NaamDocent + "\n");
                    ResultTextBox.AppendText("Aantal uren " + arr[i].Uren);

                    found = true;
                }
                i++;
            }
            stopwatch.Stop();

            MessageBox.Show(stopwatch.ElapsedMilliseconds + " ");
        }

        private void ZoekenDictButton_Click(object sender, RoutedEventArgs e)
        {
            stopwatch.Start();
            ResultTextBox.Clear();
            if (dictionary.ContainsKey(ZoekTextBox.Text))
            {
                ResultTextBox.AppendText("Vakgegevens voor " + dictionary[ZoekTextBox.Text].Naam + "\n");
                ResultTextBox.AppendText("Naam docent " + dictionary[ZoekTextBox.Text].NaamDocent + "\n");
                ResultTextBox.AppendText("Aantal uren " + dictionary[ZoekTextBox.Text].Uren);
            }
            stopwatch.Stop();

            MessageBox.Show(stopwatch.ElapsedMilliseconds + " ");
        }

        private void ZoekenListutton_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBox.Clear();
            int i = 0;
            bool found = false;
            while (!found && i < 1000)
            {
                if (arr[i].Naam == ZoekTextBox.Text)
                {
                    ResultTextBox.AppendText("Vakgegevens voor " + arr[i].Naam + "\n");
                    ResultTextBox.AppendText("Naam docent " + arr[i].NaamDocent + "\n");
                    ResultTextBox.AppendText("Aantal uren " + arr[i].Uren);

                    found = true;
                }
                i++;
            }


        }
    }
}
