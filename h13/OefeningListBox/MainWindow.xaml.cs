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

namespace OefeningListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> shoppingList  = new List<string>() { "Bread", "Milk", "Coffee"};
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshListBox();            
        }

        private void RefreshListBox()
        {
            ShoppingListBox.ItemsSource = null;
            ShoppingListBox.ItemsSource = shoppingList;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            shoppingList.Add("Tea");
            RefreshListBox();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ShoppingListBox.Items.Clear();
        }

        private void ContainsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IndexOfButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
