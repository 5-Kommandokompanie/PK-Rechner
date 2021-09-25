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
using MaterialDesignThemes;
using MaterialDesignColors;

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
                MaterialDesignThemes.Wpf.ButtonProgressAssist.SetIsIndeterminate(Berechnen, true);
                PKRechner pk = new PKRechner(Geburtsdatum.Text, nachname, kwea, int.Parse(Lfd.Text));
                pk.PKBerechnen();
                if (!pk.IsOK)
                {
                    ClearData();
                    return;
                }
                string pkennziff = pk.PK;

                PK.Visibility = Visibility.Visible;
                PK.Text = pkennziff;
                Clipboard.SetText($"{pkennziff}");
                PK_Cpy_lbl.Content = "Deine PK wurde in die Zwischenablage kopiert!";
            }
            catch
            {
                MaterialDesignThemes.Wpf.ButtonProgressAssist.SetIsIndeterminate(Berechnen, false);
                MessageBox.Show("Bitte geben Sie Daten ein, die vom Programm verarbeitet werden können!\n\nBei Fragen wenden Sie sich bitte an den Hersteller.", "Bitte korrekte Daten eingeben", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally
            {
                MaterialDesignThemes.Wpf.ButtonProgressAssist.SetIsIndeterminate(Berechnen, false);
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            MaterialDesignThemes.Wpf.ButtonProgressAssist.SetIsIndeterminate(Reset, true);
            ClearData();
            MaterialDesignThemes.Wpf.ButtonProgressAssist.SetIsIndeterminate(Reset, false);
        }

        private void ClearData()
        {
            Geburtsdatum.Clear();
            Nachname.SelectedItem = null;
            KWEA.SelectedItem = null;
            Lfd.Clear();
            PK.Visibility = Visibility.Collapsed;
            PK.Clear();
            Clipboard.Clear();
            PK_Cpy_lbl.Content = "Gib alle Daten im korrekten Format ein";
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
            if (Nachname.SelectedItem is not null)
            {
                Nachname item = Nachname.SelectedItem as Nachname;
                nachname = item;
            }
        }

        private void KWEA_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (KWEA.SelectedItem is not null)
            {
                KWEA item = KWEA.SelectedItem as KWEA;
                kwea = item.Nummer;
            }
        }
    }
}
