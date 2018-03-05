using System;
using System.Windows;

namespace Exercise03
{
    public partial class MainWindow : Window
    {
        Random rand;
        double som = 0;
        double gemiddelde = 0;
        double aantal = 0;
        double randomGetal;
        public MainWindow()
        {
            InitializeComponent();

            rand = new Random();
            randomTextBox.IsEnabled = false;
            sumTextBox.IsEnabled = false;
            averageTextBox.IsEnabled = false;
        }

        private void genereerButton_Click(object sender, RoutedEventArgs e)
        {
           
            randomGetal = rand.Next(200) + 200;
            som += randomGetal;
            aantal++;

            gemiddelde = som / aantal;

            randomTextBox.Text = randomGetal.ToString();
            sumTextBox.Text = som.ToString();
            averageTextBox.Text = gemiddelde.ToString();
        }

    }
}
