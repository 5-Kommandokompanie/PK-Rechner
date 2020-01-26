using System;

namespace PK_Rechner
{
    public static class Geburtstag
    {

        //Eingabe des Geburtsdatums
        public static string[] Eingabe()
        {
            Console.Write("Geburtstag (TT.MM.JJ): ");
            string geburtsdatum = Console.ReadLine();
            string[] _geburtsdatum = geburtsdatum.Split('.');
            return _geburtsdatum;
        }

        public static int[] Split(string[] _geburtsdatum)
        {
            //Aufspaltung der Eingabe
            int.TryParse(_geburtsdatum[0], out int tag);
            int.TryParse(_geburtsdatum[1], out int monat);
            int.TryParse(_geburtsdatum[2], out int jahr);


            int[] geburtsdatum = new int[6];

            //Aufspaltung in einzelne Ziffern
            geburtsdatum[1] = tag % 10;
            tag /= 10;
            geburtsdatum[0] = tag % 10;

            geburtsdatum[3] = monat % 10;
            monat /= 10;
            geburtsdatum[2] = monat % 10;

            geburtsdatum[5] = jahr % 10;
            jahr /= 10;
            geburtsdatum[4] = jahr % 10;

            return geburtsdatum;
        }
    }
}
