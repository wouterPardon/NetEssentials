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

namespace Oefening8_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rectangle rect;
        public MainWindow()
        {
            InitializeComponent();
            DrawRectangleRects(rect);
        }


        private void DrawRectangle(Canvas canvas, SolidColorBrush colorBrush , Rectangle rectToUse, double x, double y)
        {
            rectToUse = new Rectangle();
            rectToUse.Height = 30;
            rectToUse.Width = 30;
            rectToUse.Margin = new Thickness(x, y, 0, 0);
            rectToUse.Stroke = colorBrush;
            canvas.Children.Add(rectToUse);
        }

       

        private void DrawRectangleRects(Rectangle rectToUse)
        {
            double x, y;
            int breedte = 1;
            SolidColorBrush brush = new SolidColorBrush(Colors.Red);

            y = 5;
            for (int row = 1; row <= 6; row++)
            {
                x = 5;
                for (int col = 1; col <= breedte; col++)
                {
                    DrawRectangle(tekenCanvas, brush, rectToUse, x, y);
                    x += 50;
                }

                breedte++;
                y += 50;
               
            }
        }
    }
}
