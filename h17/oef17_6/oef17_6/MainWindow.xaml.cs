using System.Windows;
namespace oef17_6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ControllerButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EmailChecker.Check(EmailTextBox.Text);
                MessageBox.Show(EmailTextBox.Text);
            }
            catch (InvalidEmailException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
