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

namespace Opgave3_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        Rectangle rectMain = new Rectangle();
        
        public MainWindow()
        {
            InitializeComponent();

            rectMain.Width = 100;
            rectMain.Height = 50;
            rectMain.Margin = new Thickness(75, 100, 10, 10);
            rectMain.Stroke = new SolidColorBrush(Colors.Red);

        

            TCanvas.Children.Add(rectMain);
        }

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            CLabel.Content = Mouse.GetPosition(TCanvas);
        }
    }
}
