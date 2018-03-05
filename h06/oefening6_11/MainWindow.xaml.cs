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
namespace oefening6_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        Line lineSec;
        Line lineMinu;
        Ellipse circle;
        
        public MainWindow()
        {
            InitializeComponent();
            CreateTimer();
            CreateLines();
            CreateCircle();
            DrawUIelement(circle, tekenCanvas);
            DrawLines(tekenCanvas);
            timer.Start();

        }

        private void Timer_tick(object sender, EventArgs e) {
            double radianSeconds = (DateTime.Now.Second * 6 - 90) * Math.PI / 180;
            double radianMinuts = (DateTime.Now.Minute * 6 - 90) * Math.PI / 180;
           

            timeLabel.Content = DateTime.Now.ToString();
            lineSec.X2 = 275 + 135 * Math.Cos(radianSeconds); 
            lineSec.Y2 = 150 + 135 * Math.Sin(radianSeconds);

            lineMinu.X2 = 275 + 100 * Math.Cos(radianMinuts);
            lineMinu.Y2 = 150 + 100 * Math.Sin(radianMinuts);

        }

        private void CreateLines() {
            lineSec = new Line();
            lineMinu = new Line();
           
            //lineSec.Height = 70;
            //lineSec.Width = 5;
            //lineSec.Margin = new Thickness(275, 140, 0, 0);
            lineSec.X1 = 275;
            lineSec.Y1 = 150;

            lineSec.X2 = 275;
            lineSec.Y2 = 11;

            lineMinu.X1 = 275;
            lineMinu.Y1 = 150;

            lineMinu.X2 = 275;
            lineMinu.Y2 = 50;

            lineSec.Stroke = new SolidColorBrush(Colors.Black);
            lineMinu.Stroke = new SolidColorBrush(Colors.Red);
           
        }

        private void CreateTimer() {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_tick;

            
        }

        private void CreateCircle() {
            circle = new Ellipse();
            circle.Height = 250;
            circle.Width = 250;

            circle.Stroke = new SolidColorBrush(Colors.Black);
            circle.Margin = new Thickness(150, 10, 0, 0);
            
        }

        private void DrawLines(Canvas canvas) {
            DrawUIelement(lineSec, canvas);
            DrawUIelement(lineMinu, canvas);
        
        }

        private void DrawUIelement(UIElement element, Canvas canvas) {
            canvas.Children.Add(element);
        }
    }
}
