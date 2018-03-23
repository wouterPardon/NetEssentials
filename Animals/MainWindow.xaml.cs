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

namespace Animals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Animal anim1, anim2, anim3;
        public MainWindow()
        {
            InitializeComponent();
           // anim1 = new Animal("Woefie");
            anim2 = new Dog("Pluto");
            anim3 = new SmallDogo("Fifike");

            //MessageBox.Show(anim1.ToString());
            MessageBox.Show(anim2.ToString());
        }
    }
}
