using System;
using System.Windows;
using System.Text;
namespace Exercise14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StringBuilder binaryString = new StringBuilder();
        int rest;
        public MainWindow()
        {
            InitializeComponent();
        }

        private string DecNaarBin(int number)
        {
          
            return Convert.ToString(number, 2);
        }

        private void berekenButton_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(getalTexBox.Text);

            String m = DecNaarBin(n);

            resultLabel.Content = m;
        }
    }
}
