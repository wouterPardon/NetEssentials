using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;

namespace Canon
{
  public class World
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Canvas CanvasWorld { get; set; }

        public World(Canvas canvas, int height, int width)
        {
            this.CanvasWorld = canvas;
            this.Height = height;
            this.Width = width;
        }

        public World() { }

        public void DrawScale()
        {
            double x1 = 40;
            double y1 = this.CanvasWorld.Height;
            double x2 = x1;
            double y2 = this.CanvasWorld.Height - 10;

            for (int i = 1; i <= this.Width / 10; i++)
            {
                if (i % 10 == 0)
                {
                    DrawLine(x1, y1, x2, y2 - 5);
                }else
                {
                    DrawLine(x1, y1, x2, y2);
                }

                x1 += 40;
                x2 = x1;
            }
        }

        private void DrawLine(double x1, double y1, double x2, double y2)
        {
            Line lijn = new Line
            {
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2,

                Stroke = new SolidColorBrush(Colors.Black)
            };
            CanvasWorld.Children.Add(lijn);
        }

        public double ConvertPixelToMeter(double pos)
        {
            return this.CanvasWorld.Height / this.Height * pos;
        }

        public bool IsInWorld(double x, double y)
        {
            if (x >= this.CanvasWorld.Width || y < this.CanvasWorld.Height)
            {
                return false;
            }
            return true;
        }

    }
}
