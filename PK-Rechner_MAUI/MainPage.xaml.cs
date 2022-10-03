using PK_Rechner_MAUI.ViewModels;
using System.Diagnostics;
using System.Reflection;

namespace PK_Rechner_MAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;

            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

            Title = $"{versionInfo.ProductName} v.{versionInfo.FileVersion}";
            Author.Text = versionInfo.LegalCopyright;
        }
    }
}