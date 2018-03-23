using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Oefening11_7
{
    public class FlikkerWekker : Wekker 
    {
        private Random randByte;
        private int count = 10;

        public FlikkerWekker(TextBlock currentTimeTextBlock, int afloopTijd, string alarmTijd) : base(currentTimeTextBlock, afloopTijd, alarmTijd)
        {
            randByte = new Random();
        }

        public override void WekkerTimer_Tick(object sender, EventArgs e)
        {

            if (base.CheckCurrentTimeEqToAlarm(base.AlaramTijd) && count > 0)
            {
                this.CurrentTimeTextBlock.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(randByte.Next(255)), Convert.ToByte(randByte.Next(255)), Convert.ToByte(randByte.Next(255))));
                count--;
            }
            else
            {
                this.CurrentTimeTextBlock.Background = new SolidColorBrush(Colors.White);
            }      
           
        }
    }
}
