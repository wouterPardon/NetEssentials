using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Threading;

namespace Canon
{
   public class CanonBall
    {
        public Point StartPos { get; set; }
        public int Speed { set; get; }
        public int Angle { set; get; }
        public World _World { set; get; }
        private Ellipse ball = new Ellipse();
        private DispatcherTimer timerBall;
        private DateTime startTime = new DateTime();

        public CanonBall(World world, Point startPos)
        {
            this.StartPos = new Point(startPos.X, startPos.Y);
            this._World = world;
            CreateTimer();
        }

        private void CreateTimer()
        {
            timerBall = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(10)
            };
            timerBall.Tick += TimerBall_Tick;
        }

        public void DrawBall()
        {
            ball = new Ellipse
            {
                Margin = new Thickness(this.StartPos.X, this.StartPos.Y, 0, 0),
                Stroke = new SolidColorBrush(Colors.Red),
                Height = 10,
                Width = 10,
                Fill = new SolidColorBrush(Colors.Red)
            };

            _World.CanvasWorld.Children.Add(ball);
        }

        public void ChangeXY(double x, double y)
        {
            this.ball.Margin = new Thickness(x, y, 0, 0);
        }

        private void TimerBall_Tick(object sender, EventArgs e)
        {
            double radians = this.Angle * Math.PI / 180;
            TimeSpan difference = DateTime.Now.Subtract(startTime);
            double _x = ( this.Speed * Math.Cos(radians) * difference.Seconds);
            double _y = this.Speed * Math.Sin(radians) * difference.Seconds - (1 / 2 * 9.81) * Math.Pow(difference.Seconds, 2);

            Console.WriteLine(difference.Seconds);

            this.ChangeXY(_x, _y);
        }

        public void StartShoot()
        {
            startTime = DateTime.Now;
            this.timerBall.Start();
        }
    }
}
