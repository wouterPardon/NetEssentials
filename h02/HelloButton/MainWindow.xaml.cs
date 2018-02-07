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

namespace HelloButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox test = new TextBox();

        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void klikHierButton_Click(object sender, RoutedEventArgs e)
        {
            test = (TextBox)this.FindName("TestBoxTextBox");
            test.Visibility = Visibility.Hidden;
            TestBoxTextBox.Text = "Dit is een test";
            HelloLabel.Content = "Hallo";
        }

        private void HelloTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
