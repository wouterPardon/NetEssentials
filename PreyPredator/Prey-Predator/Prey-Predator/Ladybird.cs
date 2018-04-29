using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Prey_Predator
{
    public class Ladybird: Insect, IPredator
    {
        private int roundsNotEaten = 0;
        public bool Starving { get; }
        private readonly MainWindow mainWin = Application.Current.Windows.Cast<Window>().FirstOrDefault(window => window is MainWindow) as MainWindow;

        public Ladybird(double x, double y) : base(x, y)
        {
        }

        public List<IPrey> Chase(List<IPrey> iPreyList)
        {
            List<IPrey> chasedInsects = new List<IPrey>();
            for (int index = 0; index < iPreyList.Count; index++)
            {
                if (Distance(iPreyList[index]) <= 2)
                {
                    chasedInsects.Add(iPreyList[index]);
                    iPreyList.RemoveAt(index);
                    Console.WriteLine(chasedInsects.Count);
                }
            }
            return chasedInsects;
        }

        public void Eat(List<IPrey> preys)
        {
            if (preys.Count == 0)
            {
                roundsNotEaten++;
            }
            else
            {
                roundsNotEaten = 0;
            }
        }

        public double Distance(IPrey iPrey)
        {
            return Math.Sqrt(Math.Pow(XCoord - ((Louse) iPrey).XCoord, 2) + Math.Sqrt(Math.Pow(YCoord - ((Louse)iPrey).YCoord, 2)));
        }

        public IPredator Breed()
        {
            return new Ladybird(base.XCoord, base.YCoord);
        }
    }
}