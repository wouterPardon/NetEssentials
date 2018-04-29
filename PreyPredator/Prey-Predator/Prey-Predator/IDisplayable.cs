using System.Windows.Controls;
using System.Windows.Media;

namespace Prey_Predator
{
    public interface IDisplayable
    {
        void DisplayOn(Canvas canvas, Color color);
        void RemoveFromCanvas();
        void UpdateDisplay();
    }
}