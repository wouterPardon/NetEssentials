using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Domineering
{
    public class Board
    {
        public Canvas GameCanvas { get; set; }
        private Block[,] BlocksForGrid = new Block[8, 8];
        private SolidColorBrush BlackBrush = new SolidColorBrush(Colors.Black);
        private SolidColorBrush GrayBrush = new SolidColorBrush(Colors.Gray);

        public Board(Canvas canvas)
        {
            GameCanvas = canvas;
            CreateGrid();
        }


        //Set the grid of the board filled with rects
        private void CreateGrid()
        {

            double margin = GameCanvas.Width - 14;

            for (int i = 0; i < 9; i++)
            {
                Line vertLine = new Line();
                vertLine.Stroke = BlackBrush;
                vertLine.StrokeThickness = 2;
                vertLine.X1 = (margin / 8 * i) + 7;
                vertLine.X2 = vertLine.X1;
                vertLine.Y1 = 7;
                vertLine.Y2 = GameCanvas.Height - 7;
                GameCanvas.Children.Add(vertLine);
            }

            for (int i = 0; i < 9; i++)
            {
                Line horiLine = new Line();
                horiLine.Stroke = BlackBrush;
                horiLine.StrokeThickness = 2;
                horiLine.Y1 = (margin / 8 * i) + 7;
                horiLine.Y2 = horiLine.Y1;
                horiLine.X1 = 7;
                horiLine.X2 = GameCanvas.Width - 7;
                GameCanvas.Children.Add(horiLine);
            }

            CreateBlocksForGrid();
        }

        private void CreateBlocksForGrid()
        {

        }
    }
}