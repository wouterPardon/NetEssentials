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

namespace Oefening11_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Wekker wekker;
        DispatcherTimer currentTimer;
        public MainWindow()
        {
            InitializeComponent();
            currentTimer = new DispatcherTimer()
            {
                Interval = new TimeSpan(0, 0, 1)
            };

            currentTimer.Tick += CurrentTimer_Tick;
            currentTimer.Start();
        }

        private void CurrentTimer_Tick(object sender, EventArgs e)
        {
            currentTimeTextBlock.Text = DateTime.Now.ToString().Substring(10);
        }

        private void CreateWekker()
        {
            string alarmTijd = alarmTextBox.Text;

            if (flikkerRadioButton.IsChecked == true)
            {
                wekker = new FlikkerWekker(currentTimeTextBlock, 10, alarmTijd);
            }
            else
            {
                wekker = new BeepWekker(currentTimeTextBlock, 10, alarmTijd);
            }
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            CreateWekker();
            wekker.StartWekker();
            alarmTextBox.IsEnabled = false;
            flikkerRadioButton.IsEnabled = false;
            beepRadioButton.IsEnabled = false;
        }

        private void stopButton_Click(object sender, RoutedEventArgs e)
        {
            wekker.StopWekker();
            alarmTextBox.IsEnabled = true;
            flikkerRadioButton.IsEnabled = true;
            beepRadioButton.IsEnabled = true;
        }
    }
}
