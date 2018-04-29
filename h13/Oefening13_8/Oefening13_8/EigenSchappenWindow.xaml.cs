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
using System.Windows.Shapes;

namespace Oefening13_8
{
    /// <summary>
    /// Interaction logic for EigenSchappenWindow.xaml
    /// </summary>
    public partial class EigenSchappenWindow : Window
    {
        public Persoon selectedPersoon;
        public EigenSchappenWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            selectedPersoon.Naam = NaamTextBox.Text;
            selectedPersoon.VoorNaam = VoornaamTextBox.Text;
            selectedPersoon.GeboorteDatum = (DateTime)GeboorteDatePicker.SelectedDate;
            selectedPersoon.Adres = AdresTextBox.Text;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
