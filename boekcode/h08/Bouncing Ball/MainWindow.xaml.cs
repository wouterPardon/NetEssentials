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
using System.Windows.Threading;

namespace Bouncing_Ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        private Ellipse ellipse;
        double x, y, diameter;
        int xChange = 10;
        int yChange = 4;
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            ellipse = new Ellipse();

            timer.Interval = TimeSpan.FromMilliseconds(200);
            timer.Tick += timer_tick;
        }

        private void ballCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {   
            x = 10;
            y = 10;
            diameter = 15;
                     
            DrawBall();
            timer.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            MoveBall();
           
        }

        private void MoveBall()
        {
            if ((x <= 0) || (x >= ballCanvas.Width))
            {
                xChange = -xChange;
            }
            if ((y <= 0) || (y >= ballCanvas.Height))
            {
                yChange = -yChange;
            }

            x = x + xChange;
            y = y + yChange;

            ellipse.Margin = new Thickness(x, y, 0, 0);
        }

        private void DrawBall()
        {
            
            ellipse.Stroke = new SolidColorBrush(Colors.Blue);
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ballCanvas.Children.Add(ellipse);
        }
    }
}
