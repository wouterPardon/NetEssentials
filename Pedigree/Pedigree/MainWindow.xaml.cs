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

namespace Pedigree
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Duif duif;
        Lijst pedigree;
       
        public MainWindow()
        {
            InitializeComponent();
            duif = new Duif("", "");
            pedigree = new Lijst();
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            duif.Ringnummer = RingnummerTextbox.Text;
            duif.Kleur = KleurTextBox.Text;
            duif.Moeder = MoederTextBox.Text;
            duif.Vader = VaderTextBox.Text;

            if (DuifRadio.IsChecked == true)
            {
                duif.Geslacht = DuifRadio.Content.ToString();

            }
            else
            {
                duif.Geslacht = DuivinRadio.Content.ToString();
            }

            pedigree.Add(duif);

        }

        private void JongRectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RJongLabel.Content = duif.Ringnummer;
            KJongLabel.Content = duif.Kleur;
        }

        private void VaderRectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RVaderLabel.Content = duif.Ringnummer;
            KvaderLabel.Content = duif.Kleur;
        }

        private void MoederRectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RMoederLabel.Content = duif.Ringnummer;
            KMoederLabel.Content = duif.Kleur;
        }

        private void GrootVaderRectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
           RGrootVaderLabel.Content = duif.Ringnummer;
           KGrootvaderLabel.Content = duif.Kleur;
        }

        private void GrootMoederRectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RGrootMoederLabel.Content = duif.Ringnummer;
            KGrootMoederLabel.Content = duif.Kleur;
        }

        private void GrootVaderLMRectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RGrootVaderLMLabel.Content = duif.Ringnummer;
            KGrootvaderLMLabel.Content = duif.Kleur;
        }
    }
}
