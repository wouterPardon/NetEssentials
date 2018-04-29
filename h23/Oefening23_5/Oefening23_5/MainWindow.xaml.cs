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

namespace Oefening23_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyList<string> strings = new MyList<string>();
        public MainWindow()
        {
            InitializeComponent();
            strings.Add("Halo");
            strings.Add("Goeiemorgen");

            for (int i = 0; i < 2; i++)
            {
                MessageBox.Show(strings.arr[i]);
            }
                
            }
        }
    }
