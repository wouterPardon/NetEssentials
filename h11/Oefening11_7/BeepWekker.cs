using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Oefening11_7
{
    public class BeepWekker : Wekker
    {
        private int count = 10;

        public BeepWekker(TextBlock currentTimeTextBlock, int afloopTijd, string alarmTijd) : base(currentTimeTextBlock, afloopTijd, alarmTijd)
        {

        }

        public BeepWekker()
        {

        }

        public override void WekkerTimer_Tick(object sender, EventArgs e)
        {
            if (base.CheckCurrentTimeEqToAlarm(base.AlaramTijd) && count > 0)
            {
                Console.Beep();
                count--;
            }
        }
    }
}
