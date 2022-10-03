using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace PK_Rechner_MAUI.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        MaxDate = DateTime.Today.AddYears(-16);
        Date = DateTime.Today.AddYears(-20);

        Buchstaben = new ObservableCollection<Nachname>();
        Buchstaben = Helper.InitializeChars(Buchstaben);
        Buchstabe = Buchstaben.FirstOrDefault();

        Kweas = new ObservableCollection<KWEA>();
        Kweas = Helper.InitializeKWEAs(Kweas);
        Kwea = Kweas.FirstOrDefault();

        Lfds = new ObservableCollection<int>();
        Lfds = Helper.InitializeLfd(Lfds);
        Lfd = Lfds.FirstOrDefault();

        Pk = "Die PK lautet: ";
    }

    [ObservableProperty]
    DateTime maxDate;

    [ObservableProperty]
    DateTime date;

    [ObservableProperty]
    ObservableCollection<Nachname> buchstaben;

    [ObservableProperty]
    Nachname buchstabe;

    [ObservableProperty]
    ObservableCollection<KWEA> kweas;

    [ObservableProperty]
    KWEA kwea;

    [ObservableProperty]
    ObservableCollection<int> lfds;

    [ObservableProperty]
    int lfd;

    [ObservableProperty]
    string pk;

    [RelayCommand]
    async void Berechnen()
    {
        if(Buchstabe is not null && Kwea is not null && Lfd > 0)
        {
            PKRechner pk = new PKRechner(Date.ToShortDateString(), Buchstabe, Kwea.Nummer, Lfd);
            pk.PKBerechnen();
            if (!pk.IsOK)
            {
                await Shell.Current.DisplayAlert("Geburtsdatum invalide", "Bitte korrekte Daten eingeben", "OK");
            }
            Pk = $"Die PK lautet: {pk.PK}";
            await Clipboard.SetTextAsync(pk.PK);
        }
        else
        {
            await Shell.Current.DisplayAlert("Fehlende Daten", "Bitte alle Daten eingeben", "OK");
        }
    }

    [RelayCommand]
    void Reset()
    {
        Date = DateTime.Today.AddYears(-20);
        Buchstabe = Buchstaben.FirstOrDefault();
        Kwea = Kweas.FirstOrDefault();
        Lfd = Lfds.FirstOrDefault();
        Pk = "Die PK lautet: ";
    }
}
