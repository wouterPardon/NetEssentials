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

namespace WekkerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Wekker wekker = new Wekker();
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_tick;
            timer.Start();
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            currentTimerLabel.Content = DateTime.Now.ToString();
        }

        private int GetHourFromTextBox() {
            return Convert.ToInt32(alarmTijdTextBox.Text.ToString().Substring(0, 2));
        }

        private int GetMinuteFromTextBox()
        {
            return Convert.ToInt32(alarmTijdTextBox.Text.Substring(3, 2));
        }

        private void starAlarmButton_Click(object sender, RoutedEventArgs e)
        {
            alarmTijdTextBox.IsEnabled = false;
            wekker.AlarmTijd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, GetHourFromTextBox(), GetMinuteFromTextBox(), 0);           
            wekker.StartAlarm();

            MessageBox.Show("Uw wekker is gezet om: " + wekker.AlarmTijd.Hour + ":" + wekker.AlarmTijd.Minute + ":00");
            MessageBox.Show("U hebt nog " + wekker.GetTimeLeft().Hours + " uur en " + wekker.GetTimeLeft().Minutes + " minuten voor uw alarm afgaat");
        }

        private void stopAlarmButton_Click(object sender, RoutedEventArgs e)
        {
            wekker.StopAlarm();
            alarmTijdTextBox.IsEnabled = true;
        }
    }
}
