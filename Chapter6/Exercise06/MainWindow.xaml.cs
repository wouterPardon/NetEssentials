using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Windows.Controls;

namespace Exercise06
{
    public partial class MainWindow : Window
    {
        private Rectangle rectSec;
        private Rectangle rectMinu;
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            CreateRectangles();
            timer.Tick += Timer_tick;
            Draw(tekenCanvas, rectSec);
            Draw(tekenCanvas, rectMinu);

            timer.Start();
        }


        private void CreateRectangles() {
            rectSec = new Rectangle();
            rectMinu = new Rectangle();

            rectSec.Margin = new Thickness(0, 50, 0, 0);
            
            rectSec.Height = 75;
            rectSec.Width = 0;

            rectSec.Stroke = new SolidColorBrush(Colors.Black);
            rectSec.MaxWidth = 600;

            rectMinu.Margin = new Thickness(0, 200, 0, 0);

            rectMinu.Height = 75;
            rectMinu.Width = 0;

            rectMinu.Stroke = new SolidColorBrush(Colors.Black);
            rectMinu.MaxWidth = 600;

            rectSec.Fill = new SolidColorBrush(Colors.Black);
            rectMinu.Fill = new SolidColorBrush(Colors.Black);
        }


        public void Draw(Canvas canvasToUse, UIElement obj)
        {
            canvasToUse.Children.Add(obj);
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            rectSec.Width = rectSec.Width + 10;

            if (IsGreaterThenSixty(rectSec)) {
                rectSec.Width = 0;
                rectMinu.Width += 10;
            }

            if (IsGreaterThenSixty(rectMinu)) {
                rectMinu.Width = 0;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private bool IsGreaterThenSixty(Rectangle rect) {
            if (rect.Width >= 600) {
                return true;
            }
            return false;
        }

        public void ResetWidth(Rectangle rect)
        {
            rect.Width = 0;
        }
    }
}
