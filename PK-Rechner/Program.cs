using System;
using System.Windows.Forms;

namespace PK_Rechner
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            string[] geburtsdatum = Geburtstag.Eingabe();
            int[] geburtstag = Geburtstag.Split(geburtsdatum);

            int nachname = Nachname.Eingabe();

            int _kwea = KWEA.Eingabe();
            int[] kwea = KWEA.Split(_kwea);

            Console.Write("Leitfadenzahl (eigl. immmer 1): ");
            int lfd = Convert.ToInt32(Console.ReadLine());

            int pruef = Rechnung(geburtstag, nachname, kwea, lfd);

            string pk = $"{string.Join("", geburtsdatum)}-{Nachname.Buchstabe}-{_kwea}{lfd}{pruef}";
            Console.WriteLine($"DEINE PERSONENKENNZIFFER LAUTET: {pk}");
            Clipboard.SetText($"{pk}");
            Console.WriteLine("\n\nDie PK wurde in die Zwischenablage kopiert!");
            Console.ReadKey();
        }

        static int Rechnung(int[] geburtstag, int nachname, int[] kwea, int lfd)
        {

            geburtstag[0] *= 2;
            geburtstag[1] *= 3;
            geburtstag[2] *= 4;
            geburtstag[3] *= 5;
            geburtstag[4] *= 6;
            geburtstag[5] *= 7;
            kwea[0] *= 6;
            kwea[1] *= 7;
            kwea[2] *= 2;
            lfd *= 3;

            int sum = geburtstag[0] + geburtstag[1] + geburtstag[2] + geburtstag[3] + geburtstag[4] + geburtstag[5] + nachname + kwea[0] + kwea[1] + kwea[2] + lfd;
            int mod = sum % 11;
            int diff = 11 - mod;

            switch (diff)
            {
                case 10:
                    return 0;

                case 11:
                    return 1;

                default:
                    return diff;
            }
        }
    }


}
