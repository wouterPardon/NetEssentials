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

namespace Oefening17_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Bankrekening rekening = new Bankrekening("1545548");
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                rekening.StortGeld(3000);
            }
            catch (WrongSaldoException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
