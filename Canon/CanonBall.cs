using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Threading;
using System.Windows.Controls;

namespace Canon
{
    public class CanonBall
    {
        public Point StartPos { get; set; }
        public int Speed { set; get; }
        public int Angle { set; get; }
        public World _World { set; get; }
        public Label HeightLabel { set; get; }
        public Label WidthLabel { set; get; }
        private Ellipse ball = new Ellipse();
        private DispatcherTimer timerBall;
        private double startTime = 0;
        private double x;
        private double y;
        private double radians;
        public CanonBall(World world, Point startPos, Label heightLabel, Label widthLabel)
        {
            this.StartPos = new Point(startPos.X, startPos.Y);
            this._World = world;
            this.HeightLabel = heightLabel;
            this.WidthLabel = widthLabel;
            this.x = startPos.X + 1;
            this.y = startPos.Y;

            CreateTimer();
        }

        private void CreateTimer()
        {
            timerBall = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 0, 0, 10)
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
            radians = this.Angle * Math.PI / 180;
            x = BerekenX((double)this.Speed, radians, startTime / 1000) + this.StartPos.X ;
            y = this.StartPos.Y - BerekenY((double)this.Speed, radians, startTime / 1000);
            Console.WriteLine(y * (this._World.Height / 120) + " " + x * (this._World.Height / 300));
            ChangeXY(x, y * (this._World.Height / 120));

            if (_World.IsInWorld(x, y))
            {
                timerBall.Stop();
            }
            startTime += 10;
        }

        public double BerekenX(double v, double alpha, double t)
        {
            return (v * Math.Cos(alpha) * t);
        }

        public double BerekenY(double v, double alpha, double t)
        {
            return (v * Math.Sin(alpha) * t) - (0.5 * 9.81 * (t * t));
        }

        public void StartShoot()
        {
            this.timerBall.Start();
        }
    }
}
