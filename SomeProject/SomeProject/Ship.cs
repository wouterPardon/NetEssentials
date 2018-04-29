using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SomeProject
{
    public class Ship
    {
        protected BitmapImage BitmapImage { get; set; }
        protected Image Image { get; set; }

        public Ship(BitmapImage bi)
        {
            this.BitmapImage = bi;
        }

        protected void CreateImage()
        {
            this.Image = new Image()
            {
                Width = this.BitmapImage.Width,
                Height = this.BitmapImage.Height,
                Source = this.BitmapImage
            };
        }

        protected void DrawShip()
        {
            this.Image.Margin = new Thickness(5, 5, 0, 0);
        }
    }
}