using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Oefening11_7
{
    public abstract class Wekker
    {
        protected int AfloopTijd { get; set; }
        protected DateTime AlaramTijd { get; set; }
        protected TextBlock CurrentTimeTextBlock;
        private DispatcherTimer wekkerTimer;

        public Wekker(TextBlock currentTimeTextBlock, int afloopTijd, string alarmTijd)
        {
            this.CurrentTimeTextBlock = currentTimeTextBlock;
            this.AfloopTijd = afloopTijd;
            this.AlaramTijd = CreateAlarmTijdFromString(alarmTijd);
            this.CreateTimerAfloop();
          
        }

        public Wekker()
        {
            this.CreateTimerAfloop();
        }

        private int GetMinutsTimer(string tijd)
        {
            return Convert.ToInt32(tijd.Substring(3, 2));
        }

        private int GetHours(string tijd)
        {
            return Convert.ToInt32(tijd.Substring(0, 2));
        }

        private DateTime CreateAlarmTijdFromString(string tijd)
        {
            int hour = GetHours(tijd);
            int minute = GetMinutsTimer(tijd);
            Console.WriteLine(hour + " " + minute);
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, 0);
        }

        public void CreateTimerAfloop()
        {
            wekkerTimer = new DispatcherTimer()
            {
                Interval = new TimeSpan(0, 0, 1)
            };

            wekkerTimer.Tick += WekkerTimer_Tick;
        }

        public bool CheckCurrentTimeEqToAlarm(DateTime alarm)
        {
            if (DateTime.Now.Hour == alarm.Hour && DateTime.Now.Minute == alarm.Minute)
            {
                return true;
            }
            return false;
        }

       
        public abstract void WekkerTimer_Tick(object sender, EventArgs e);

        public void StartWekker()
        {
            this.wekkerTimer.Start();
        }

        public void StopWekker()
        {
            this.wekkerTimer.Start();
        }
    }
}
