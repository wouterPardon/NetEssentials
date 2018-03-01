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

namespace Opgave3_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Shape[] figuren;
        Line lijn1;
        Line lijn2;
        Line lijn3;

        public MainWindow()
        {
            InitializeComponent();

            figuren = new Shape[3];
            lijn1 = new Line();
            lijn2 = new Line();
            lijn3 = new Line();
        }

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            lijn1.X1 = 215;
            lijn1.Y1 = 170;

            lijn1.X2 = 100;
            lijn1.Y2 = 170;

            lijn2.X1 = 215;
            lijn2.Y1 = 170;

            lijn2.X2 = 215;
            lijn2.Y2 = 100;

            lijn3.X1 = 215;
            lijn3.Y1 = 100;

            lijn3.X2 = 100;
            lijn3.Y2 = 170;

            figuren[0] = lijn1;
            figuren[1] = lijn2;
            figuren[2] = lijn3;

            for (int i = 0; i < figuren.Length; i++) {
                figuren[i].StrokeThickness = 2;
                figuren[i].Stroke = new SolidColorBrush(Colors.Red);

                TekeningCanvas.Children.Add(figuren[i]);
            }
        }

        private void TekeningCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            XYLabel.Content = Mouse.GetPosition(TekeningCanvas);
        }
    }
}
