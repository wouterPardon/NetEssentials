using System.Windows;
using System.Data;
using System.Web;
using System;
using System.Windows.Controls;
namespace Exercise07
{
    public partial class MainWindow : Window
    {
        //string value = "";
       //DataTable dt;
	   private int number;
	   private int result = 0;
        private string previousOperator = "+";
	   private string nextOperator;
	   private bool newNumberEntered;
        public MainWindow()
        {
            InitializeComponent();
            //dt =  new DataTable();
        }
		
		private void ButtonDigit_click(object sender, RoutedEventArgs e)
		{
			displayTextBox.Text += ((Button)sender).Content;
		}
		
		private void ClearDisplay()
		{
			if(newNumberEntered)
			{
				displayTextBox.Text = "";
			}
			
			newNumberEntered = false;
		}
		
		private void ButtonOperator_click(object sender, RoutedEventArgs e)
		{
            ClearDisplay();
			number = Convert.ToInt32(displayTextBox.Text);
			nextOperator = Convert.ToString(((Button)sender).Content);
			newNumberEntered = true;
			
			Count();
		}
		
		private void Count()
		{
			switch(previousOperator)
			{
				case "+":
					result += number;
				break;
				
				case "-":
					result += number;
				break;
				
				default:
					MessageBox.Show("Foutieve operator");
				break;
			}
			
			displayTextBox.Text = Convert.ToString(result);

            if (nextOperator == "=")
            {
                InitCalculatorState();
            }else
            {
                previousOperator = nextOperator;
            }
			
		}

        private void InitCalculatorState()
        {
            previousOperator = "+";
            result = 0;
        }
		

       /*  private void éénButton_Click(object sender, RoutedEventArgs e)
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
 */

/*         private void Update(string number)
        {
            if (number == "")
            {
                value = "0";

            }else
            {
                value += number;
            }
            
            displayTextBox.Text = value;
        }

        private void resultaatButton_Click(object sender, RoutedEventArgs e)
        {
            char[] tekst = value.ToCharArray();

            if (value[tekst.Length - 1] == '+' || value[tekst.Length - 1] == '-') {
                value += "0";
            } else if (value[tekst.Length - 1] == '*')
            {
                value += "1";
            }

            displayTextBox.Text = BerekenResultaat();
            ClearValue();
        }

        private string BerekenResultaat()
        {
            return dt.Compute(value, "").ToString();
        }

        private void ClearValue()
        {
            value = "";
        } */
    }
}
