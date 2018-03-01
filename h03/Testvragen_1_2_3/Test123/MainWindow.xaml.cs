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

namespace Test123
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        Ellipse circle = new Ellipse();
        Line lineBase = new Line();
        Line lineHorizontal = new Line();
        Rectangle rect = new Rectangle();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void DrawingButton_Click(object sender, RoutedEventArgs e)
        {
            circle.Width = 100;
            circle.Height = 100;
            circle.Stroke = new SolidColorBrush(Colors.Blue);
            circle.Margin = new Thickness(10, 10, 0, 0);
            circle.Fill = new SolidColorBrush(Colors.Red);

            rect.Stroke = new SolidColorBrush(Colors.Red);
            rect.Height = 50;
            rect.Width = 50;
            rect.Margin = new Thickness(0,15, 15, 0);

            lineBase.X1 = 185;
            lineBase.Y1 = 223;
            lineBase.X2 = 185;
            lineBase.Y2 = 130;
           
            lineBase.Stroke = new SolidColorBrush(Colors.Red);
            lineBase.StrokeThickness = 5;

            lineHorizontal.X1 = 143;
            lineHorizontal.Y1 = 130;
            lineHorizontal.X2 = 223;
            lineHorizontal.Y2 = 130;

            lineHorizontal.Stroke = new SolidColorBrush(Colors.Red);
            lineHorizontal.StrokeThickness = 5;

            TekeningCanvas.Children.Add(circle);
            TekeningCanvas.Children.Add(lineBase);
            TekeningCanvas.Children.Add(lineHorizontal);
            TekeningCanvas.Children.Add(rect);
            
        }

        private void TekeningCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            XLabel.Content = Mouse.GetPosition(TekeningCanvas).ToString();
        }
    }
}
