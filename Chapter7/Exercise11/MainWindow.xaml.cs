using System.Windows;
using System;
namespace Exercise11
{
    public partial class MainWindow : Window
    {
        private Random rand = new Random();
        private Random rand2;
        public MainWindow()
        {
            InitializeComponent();

            rand2 = new Random();
        }

        private void random1Button_Click(object sender, RoutedEventArgs e)
        {
            randomLabel1.Content = rand.Next(5000).ToString();
        }

        private void random2Button_Click(object sender, RoutedEventArgs e)
        {
            randomLabel2.Content = rand2.Next(5000).ToString();
        }
    }
}
