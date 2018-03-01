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

namespace FirstDrawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Rectangle rectangle = new Rectangle();

        public MainWindow()
        {
            InitializeComponent();

            Canvas_1.Background = new SolidColorBrush(Colors.Gray);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            rectangle.Height = 100;
            rectangle.Width = 50;
            rectangle.Margin = new Thickness(10, 10, 0, 0);
            rectangle.Stroke = new SolidColorBrush(Colors.Red);
            

            Canvas_1.Children.Add(rectangle);

        }
    }


}
