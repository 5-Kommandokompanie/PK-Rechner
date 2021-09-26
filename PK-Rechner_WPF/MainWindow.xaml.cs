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
using MaterialDesignThemes.Wpf;

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

            var paletteHelper = new PaletteHelper();
            var theme = paletteHelper.GetTheme();

            DarkModeToggleButton.IsChecked = theme.GetBaseTheme() == BaseTheme.Dark;

            if (paletteHelper.GetThemeManager() is { } themeManager)
            {
                themeManager.ThemeChanged += (_, e)
                    => DarkModeToggleButton.IsChecked = e.NewTheme?.GetBaseTheme() == BaseTheme.Dark;
            }

            AddVersionNumber();

            nachnamen = Helper.InitializeChars(nachnamen);
            Nachname.ItemsSource = nachnamen;

            kweas = Helper.InitializeKWEAs(kweas);
            KWEA.ItemsSource = kweas;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
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
                    ClearPK();
                    Dialog.Content = "Bitte geben Sie Daten ein, die vom Programm verarbeitet werden können!\n\nBei Fragen wenden Sie sich bitte an den Hersteller.";
                    return;
                }
                string pkennziff = pk.PK;

                PK.Visibility = Visibility.Visible;
                PK.Text = pkennziff;
                Clipboard.SetText($"{pkennziff}");
                PK_Cpy_lbl.Content = "Deine PK wurde in die Zwischenablage kopiert!";
                Dialog.Content = "Deine PK wurde in die Zwischenablage kopiert!";
            }
            catch
            {
                ButtonProgressAssist.SetIsIndeterminate(Berechnen, false);
                Dialog.Content = "Bitte geben Sie Daten ein, die vom Programm verarbeitet werden können!\n\nBei Fragen wenden Sie sich bitte an den Hersteller.";
            }
            finally
            {
                ButtonProgressAssist.SetIsIndeterminate(Berechnen, false);
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            ButtonProgressAssist.SetIsIndeterminate(Reset, true);
            Geburtsdatum.Clear();
            Nachname.SelectedItem = null;
            KWEA.SelectedItem = null;
            Lfd.Clear();
            ClearPK();
            ButtonProgressAssist.SetIsIndeterminate(Reset, false);
        }

        private void ClearPK()
        {
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
            Header.Text += $" v.{versionInfo.FileVersion}";
            AutorMenu.Content = versionInfo.LegalCopyright;
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

        private void MenuDarkModeButton_Click(object sender, RoutedEventArgs e)
            => ModifyTheme(DarkModeToggleButton.IsChecked == true);

        private static void ModifyTheme(bool isDarkTheme)
        {
            var paletteHelper = new PaletteHelper();
            var theme = paletteHelper.GetTheme();

            theme.SetBaseTheme(isDarkTheme ? Theme.Dark : Theme.Light);
            paletteHelper.SetTheme(theme);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
