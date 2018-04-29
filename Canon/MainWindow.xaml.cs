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

namespace Canon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        World world;
        CanonBall canonBall;
        
        public MainWindow()
        {
            InitializeComponent();
           
            world = new World(canonCanvas, 120, 300);
            canonBall = new CanonBall(world, new Point(0, canonCanvas.Height - canonCanvas.Height / 15), heightLabel, DistanceLabel);
            world.DrawScale();
            canonBall.DrawBall();
            speedSlider.ValueChanged += SpeedSlider_ValueChanged;
            angleSlider.ValueChanged += AngleSlider_ValueChanged;
            shootButton.Click += ShootButton_Click;
        }

      

        private void AngleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            angleLabel.Content = angleSlider.Value;
            canonBall.Angle = Convert.ToInt32(angleSlider.Value);
        }

        private void SpeedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            speedLabel.Content = speedSlider.Value;
            canonBall.Speed = Convert.ToInt32(speedSlider.Value);
        }

        private void ShootButton_Click(object sender, RoutedEventArgs e)
        {
            angleSlider.IsEnabled = false;
            speedSlider.IsEnabled = false;

            canonBall.StartShoot();
        }
    }
}
