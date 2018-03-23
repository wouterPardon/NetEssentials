using System.Windows;

namespace Exercise14
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Uw bedrag: " + getAmountOfMoney());
        }

        private bool checkIfFirstCatIsTrue() {
            if (firstCatRadioButton.IsChecked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkIgSecondCatIsTrue()
        {
            if (secondCatRadioButton.IsChecked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkIfThirdCatIsTrue()
        {
            if (thirdCatRadioButton.IsChecked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool checkIfLastCatIsTrue()
        {
            if (lastCatRadioButton.IsChecked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private double getAmountOfMoney()
        {
            if (checkIfFirstCatIsTrue())
            {
                return 20;
            } else if (checkIgSecondCatIsTrue())
            {
                return 40;
            } else if (checkIfThirdCatIsTrue())
            {
                return 60;
            } else if (checkIfLastCatIsTrue())
            {
                return 810;
            }

            return 0;
        }
    }
}
