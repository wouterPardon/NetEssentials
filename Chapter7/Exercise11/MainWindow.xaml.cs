using System.Windows;
using System;
namespace Exercise11
{
    public partial class MainWindow : Window
    {
        private Random rand;
        private Random rand2;
        public MainWindow()
        {
            InitializeComponent();

         
        }

        private void random1Button_Click(object sender, RoutedEventArgs e)
        {
            rand = new Random(5000);
            randomLabel1.Content = rand.Next(5000).ToString();
        }

        private void random2Button_Click(object sender, RoutedEventArgs e)
        {
            rand2 = new Random(5000);
            randomLabel2.Content = rand2.Next().ToString();
        }
    }
}
