using System.Windows;
using System.Data;
namespace Exercise07
{
    public partial class MainWindow : Window
    {
        string value = "";
        DataTable dt;
        public MainWindow()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void éénButton_Click(object sender, RoutedEventArgs e)
        {
            Update("1");
        }

        private void tweeButton_Click(object sender, RoutedEventArgs e)
        {
            Update("2");
        }

        private void drieButton_Click(object sender, RoutedEventArgs e)
        {
            Update("3");
        }

        private void vierButton_Click(object sender, RoutedEventArgs e)
        {
            Update("4");
        }

        private void vijfButton_Click(object sender, RoutedEventArgs e)
        {
            Update("5");
        }

        private void zesButton_Click(object sender, RoutedEventArgs e)
        {
            Update("6");
        }

        private void zevenButton_Click(object sender, RoutedEventArgs e)
        {
            Update("7");
        }

        private void achtButton_Click(object sender, RoutedEventArgs e)
        {
            Update("8");
        }

        private void negenButton_Click(object sender, RoutedEventArgs e)
        {
            Update("9");
        }

        private void nulButton_Click(object sender, RoutedEventArgs e)
        {
            Update("0");
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            Update("");
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            Update("+");
        }

        private void minButton_Click(object sender, RoutedEventArgs e)
        {
            Update("-");
        }

        private void maalButton_Click(object sender, RoutedEventArgs e)
        {
            Update("*");
        }


        private void Update(string number)
        {
            if (number == "")
            {
                value = "";

            }
            else
            {
                value += number;
            }

            displayTextBox.Text = value;
        }

        private void resultaatButton_Click(object sender, RoutedEventArgs e)
        {
            char[] tekst = value.ToCharArray();

            if (value[tekst.Length - 1] == '+' || value[tekst.Length - 1] == '-')
            {
                value += "0";
            }

            displayTextBox.Text = dt.Compute(value, "").ToString();
            value = "";
        }
    }
}
