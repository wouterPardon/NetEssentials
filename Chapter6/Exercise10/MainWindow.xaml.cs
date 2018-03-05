using System;
using System.Windows;
using System.Windows.Threading;

namespace Exercise10
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();

            loginProgressBar.Value = 0;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_tick;
            timer.Start();
        }

        private void Timer_tick(object sender, EventArgs e) {
            loginProgressBar.Value += 20;

            if (IsLoadedProgressBar()){            
                timer.Stop();
                OkButton.IsEnabled = false;
            }
        }

        private bool IsLoadedProgressBar() {
            if (loginProgressBar.Value == 100) {
                return true;
            }

            return false;
        }

        
    }
}
