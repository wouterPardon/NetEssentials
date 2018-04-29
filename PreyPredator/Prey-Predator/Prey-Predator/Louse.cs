using System.Windows.Media.Media3D;

namespace Prey_Predator
{
    public class Louse : Insect, IPrey
    {
        public Louse(double x, double y) : base(x, y)
        {
        }

        public IPrey Breed()
        {
            if (base.Age % 5 == 0)
            {
                return new Louse(base.XCoord, base.YCoord);
            }
            return null;
        }
    }
}