using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Exercise06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawHouse(Canvas drawingArea,
                               SolidColorBrush brushToUse,
                               double topRoofX,
                               double topRoofY,
                               double width,
                               double height)
        {
            DrawTriangle(drawingArea, brushToUse, topRoofX, topRoofY, width, height);
            DrawRectangle(drawingArea, brushToUse, topRoofX, topRoofY + height, width, height);
        }

        private void DrawStreet(Canvas drawingArea, SolidColorBrush brushToUse, int x, int y, int width, int height)
        {
            DrawHouse(drawingArea, brushToUse, x, y, width, height);
            DrawHouse(drawingArea, brushToUse, x + 20, y, width, height);
            DrawHouse(drawingArea, brushToUse, x + 40, y, width, height);
            DrawHouse(drawingArea, brushToUse, x + 60, y, width, height);

           
        }

        private void DrawTriangle(Canvas drawingArea,
                                  SolidColorBrush brushToUse,
                                  double xPlace,
                                  double yPlace,
                                  double width,
                                  double height)
        {
            DrawLine(drawingArea, brushToUse, xPlace, yPlace, xPlace, yPlace + height);
            DrawLine(drawingArea, brushToUse, xPlace, yPlace + height, xPlace + width, yPlace + height);
            DrawLine(drawingArea, brushToUse, xPlace, yPlace, xPlace + width, yPlace + height);
        }

        private void DrawLine(Canvas drawingArea,
                              SolidColorBrush brushToUse,
                              double startX, double startY,
                              double endX, double endY)
        {
            Line line = new Line();
            line.X1 = startX; line.X2 = endX;
            line.Y1 = startY; line.Y2 = endY;
            line.Stroke = brushToUse;
            line.StrokeThickness = 1;
            drawingArea.Children.Add(line);
        }

        private void DrawRectangle(Canvas drawingArea,
                                   SolidColorBrush brushToUse,
                                   double xPos,
                                   double yPos,
                                   double width,
                                   double height)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = width;
            rectangle.Height = height;
            rectangle.Margin = new Thickness(xPos, yPos, 0, 0);
            rectangle.Stroke = brushToUse;
            drawingArea.Children.Add(rectangle);
        }

        private void drawButton_Click(object sender, RoutedEventArgs e)
        {
            DrawStreet(paperCanvas, new SolidColorBrush(Colors.Black), 20, 20, 20, 20);

        }
    }
}
