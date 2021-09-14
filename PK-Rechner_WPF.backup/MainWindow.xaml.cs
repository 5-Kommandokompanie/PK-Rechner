using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

namespace PK_Rechner_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Nachname> nachnamen = new List<Nachname>();
        List<KWEA> kweas = new List<KWEA>();

        private Nachname nachname;
        private int kwea;

        public MainWindow()
        {
            InitializeComponent();

            AddVersionNumber();

            nachnamen = Helper.InitializeChars(nachnamen);
            Nachname.ItemsSource = nachnamen;

            kweas = Helper.InitializeKWEAs(kweas);
            KWEA.ItemsSource = kweas;
        }

        private void Berechnen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PKRechner pk = new PKRechner(Geburtsdatum.Text, nachname, kwea, int.Parse(Lfd.Text));
                pk.PKBerechnen();
                string pkennziff = pk.PK;

                PK_lbl.Visibility = Visibility.Visible;
                PK.Visibility = Visibility.Visible;
                PK_bd.Visibility = Visibility.Visible;
                PK.Text = pkennziff;
                Clipboard.SetText($"{pkennziff}");
                PK_Cpy_lbl.Visibility = Visibility.Visible;
            }
            catch
            {
                MessageBox.Show("Bitte geben Sie Daten ein, die vom Programm verarbeitet werden können!\n\nBei Fragen wenden Sie sich bitte an den Hersteller.", "Bitte korrekte Daten eingeben", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void AddVersionNumber()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            this.Title += $" v.{versionInfo.FileVersion}";
            Autor.Content = versionInfo.LegalCopyright;
        }

        private void Nachname_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Nachname item = Nachname.SelectedItem as Nachname;
            nachname = item;
        }

        private void KWEA_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            KWEA item = KWEA.SelectedItem as KWEA;
            kwea = item.Nummer;
        }
    }
}
