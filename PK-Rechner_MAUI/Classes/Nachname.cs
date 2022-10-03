namespace PK_Rechner_MAUI;

public class Nachname
{
    public char Buchstabe { get; set; }
    public int Gewichtung { get; set; }

    public Nachname(char _buchstabe, int _gewichtung)
    {
        Buchstabe = _buchstabe;
        Gewichtung = _gewichtung;
    }
}
