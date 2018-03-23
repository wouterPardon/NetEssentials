using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace WekkerApp
{
    class Wekker
    {
        private DispatcherTimer timer = new DispatcherTimer();
        public int AfloopTijd { get; set; }
        public DateTime AlarmTijd { set; get; }

        public Wekker(int afloopTijd)
        {
            this.AfloopTijd = afloopTijd;
            CreateTimer();
        }

        public Wekker()
        {
            this.AfloopTijd = 10;
            CreateTimer();
        }

        public string GetCurrentTime()
        {
            return DateTime.Now.ToLocalTime().ToString();
        }

        private void CreateTimer()
        {
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_tick;
        }

        public void StartAlarm()
        {
            timer.Start();
        }

        public void StopAlarm()
        {
            timer.Stop();
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            var startTime = DateTime.UtcNow;

            if (DateTime.Now.Hour == AlarmTijd.Hour && DateTime.Now.Minute == AlarmTijd.Minute)
            {
                while (DateTime.UtcNow - startTime < TimeSpan.FromSeconds(AfloopTijd))
                {
                    System.Media.SystemSounds.Beep.Play();
                }
            }
        }

        public TimeSpan GetTimeLeft()
        {
            return new TimeSpan(AlarmTijd.Hour - DateTime.Now.Hour, AlarmTijd.Minute - DateTime.Now.Minute, 0); 
        }

    }
}
