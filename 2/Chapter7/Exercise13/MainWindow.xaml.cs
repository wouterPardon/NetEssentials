using System.Windows;
using System;
namespace Exercise13
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            btwTextBox.IsEnabled = false;
            totaalTextBox.IsEnabled = false;
        }

        private double BerekenTotaal(double netto)
        {
            return netto + BerekenBtw(netto);
        }

        private double BerekenBtw(double netto)
        {
            if (verlaagdCheckbox.IsChecked == true)
            {
                return netto * 0.06;
            }
            else
            {
                return netto * 0.21;
            }
        }

        private void berekenButton_Click(object sender, RoutedEventArgs e)
        {
            double netto = Convert.ToDouble(nettoPrijsTextBox.Text);

            totaalTextBox.Text = BerekenTotaal(netto).ToString();
            btwTextBox.Text = BerekenBtw(netto).ToString();
        }
    }
}
