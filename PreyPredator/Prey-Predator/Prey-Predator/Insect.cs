using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Prey_Predator
{
    public abstract class Insect: IDisplayable
    {
        private double y;
        private double x;
        private Random random = new Random();
        public int Age { get; set; }    
        protected MainWindow mainWin = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;
        public double XCoord
        {
            get => x;
            set
            {
                if (value > 15)
                {
                    x = 15;
                }
                else if (value < 0)
                {
                    x = 0;
                }
                else
                {
                    x = value;
                }
            }
        }

        public double YCoord
        {
            get => y;
            set {
                if (value > 15)
                {
                    y = 15;
                }
                else if (value < 0)
                {
                    y = 0;
                }
                else
                {
                    y = value;
                }
            }
        }

        protected Insect(double x, double y)
        {
            XCoord = x;
            YCoord = y;
        }

        public void MoveForward()
        {
            XCoord += 2;
        }

        public void MoveBackward()
        {
            YCoord -= 2;
        }

        public void MoveLeft()
        {
            XCoord -= 2;
        }

        public void MoveRight()
        {
            XCoord += 2;
        }

        public void DisplayOn(Canvas canvas, Color color)
        {
            Ellipse ellipse = new Ellipse()
            {
                Stroke = new SolidColorBrush(color),
                Fill = new SolidColorBrush(color),
                Margin = new Thickness(XCoord * mainWin.SimulatorCanvas.Width / 15, YCoord * mainWin.SimulatorCanvas.Height / 15, 0, 0),
                Height = 5,
                Width = 5
            };

            canvas.Children.Add(ellipse);
        }

        public void RemoveFromCanvas()
        {
          
        }

        public void UpdateDisplay()
        {
           
        }
    }
}