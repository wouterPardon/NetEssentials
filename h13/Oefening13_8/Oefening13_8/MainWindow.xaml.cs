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

namespace Oefening13_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Persoon pers1;
        private Persoon pers2;
        private Persoon pers3;
        private Persoon pers4;
        private EigenSchappenWindow eigenSchappenWindow;
        List<Persoon> personen = new List<Persoon>();
        public MainWindow()
        {
            InitializeComponent();
            eigenSchappenWindow = new EigenSchappenWindow();
            pers1 = new Persoon("W", "P", GeslachtEnum.M, "HA", new DateTime(1999, 02, 15));
            pers2 = new Persoon("j", "P", GeslachtEnum.M, "HA", new DateTime(1999, 02, 15));
            pers3 = new Persoon("f", "P", GeslachtEnum.M, "HA", new DateTime(1999, 02, 15));
            pers4 = new Persoon("z", "P", GeslachtEnum.M, "HA", new DateTime(1999, 02, 15));

            personen.Add(pers1);
            personen.Add(pers2);
            personen.Add(pers3);
            personen.Add(pers4);
            ShowPeople();
        }

        
        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            Persoon seleccted = (Persoon)PersonLstBox.SelectedItem;
            eigenSchappenWindow.selectedPersoon = seleccted;
            eigenSchappenWindow.Show();
            eigenSchappenWindow.AdresTextBox.Text = seleccted.Adres;
            eigenSchappenWindow.NaamTextBox.Text = seleccted.Naam;
            eigenSchappenWindow.VoornaamTextBox.Text = seleccted.VoorNaam;
            eigenSchappenWindow.GeboorteDatePicker.SelectedDate = seleccted.GeboorteDatum;
        }

        private void ShowPeople()
        {
            PersonLstBox.Items.Clear();
            PersonLstBox.Items.Add(pers1);
            PersonLstBox.Items.Add(pers2);
            PersonLstBox.Items.Add(pers3);
            PersonLstBox.Items.Add(pers4);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            ShowPeople();
        }
    }
}
