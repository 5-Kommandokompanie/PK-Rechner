/*
 * Datei: PKRechner.cs
 * Autor: Master
 * Bearbeiter: /
 * 
 * Beschreibung:
 * Hilfsklasse, um die Personenkennziffer auszurechnen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PK_Rechner_WPF
{
    public class PKRechner
    {
        /// <summary>
        /// PK = Personenkennziffer
        /// </summary>
        /// <example>
        /// PKRechner pk = new PKRechner("24.11.85", 12, 234, 1);
        /// pk.PKBerechnen();
        /// string pkennziff = pk.PK;
        /// </example>

        public bool IsOK;

        private string pk;

        private string geburtsdatum;
        private int nachname;
        private int kwea;
        private int lfd;
        private int pruef;

        private string[] splittedGeburtsdatum;
        private int[] fertigesGeburtsdatum;

        private int geburtstag;
        private int geburtsmonat;
        private int geburtsjahr;

        private Nachname nachnameObj;

        private int[] fertigeKWEA;

        public PKRechner(string geburtsdatum, Nachname nachname, int kwea, int lfd)
        {
            this.geburtsdatum = geburtsdatum;
            this.nachname = nachname.Gewichtung;
            this.kwea = kwea;
            this.lfd = lfd;

            this.nachnameObj = nachname;
        }

        public string PK { get { return this.pk; } }

        public void PKBerechnen()
        {
            splittedGeburtsdatum = geburtsdatum.Split('.');
            Split();
            SplitKWEA();
            pruef = Rechnung();

            //Zusammensetzung des Strings der PK
            pk = $"{string.Join("", splittedGeburtsdatum)}-{nachnameObj.Buchstabe}-{kwea}{lfd}{pruef}";
        }

        private void Split()
        {
            //Aufspaltung der Eingabe
            int.TryParse(splittedGeburtsdatum[0], out geburtstag);
            int.TryParse(splittedGeburtsdatum[1], out geburtsmonat);
            int.TryParse(splittedGeburtsdatum[2], out geburtsjahr);

            int _geburtstag = geburtstag;
            int _geburtsmonat = geburtsmonat;
            int _geburtsjahr = geburtsjahr;

            //Prüfen, ob das eingegebene Datum valide ist
            IsOK = ((_geburtstag < 0 || _geburtstag > 31) || (_geburtsmonat < 0 || _geburtsmonat > 12) || (_geburtsjahr < 0 || _geburtsjahr > 99)) ? false : true;

            fertigesGeburtsdatum = new int[6];

            //Aufspaltung in einzelne Ziffern
            fertigesGeburtsdatum[1] = _geburtstag % 10;
            _geburtstag /= 10;
            fertigesGeburtsdatum[0] = _geburtstag % 10;

            fertigesGeburtsdatum[3] = _geburtsmonat % 10;
            _geburtsmonat /= 10;
            fertigesGeburtsdatum[2] = _geburtsmonat % 10;

            fertigesGeburtsdatum[5] = _geburtsjahr % 10;
            _geburtsjahr /= 10;
            fertigesGeburtsdatum[4] = _geburtsjahr % 10;
        }

        private void SplitKWEA()
        {
            fertigeKWEA = new int[3];
            int _kwea = kwea;

            //Aufspaltung in einzelne Ziffern
            fertigeKWEA[2] = _kwea % 10;
            _kwea /= 10;
            fertigeKWEA[1] = _kwea % 10;
            _kwea /= 10;
            fertigeKWEA[0] = _kwea % 10;
        }

        private int Rechnung()
        {
            int[] _geburtsdatum = fertigesGeburtsdatum;
            int[] _kwea = fertigeKWEA;
            int _lfd = lfd;
            int _nachname = nachname;

            _geburtsdatum[0] *= 2;
            _geburtsdatum[1] *= 3;
            _geburtsdatum[2] *= 4;
            _geburtsdatum[3] *= 5;
            _geburtsdatum[4] *= 6;
            _geburtsdatum[5] *= 7;
            _kwea[0] *= 6;
            _kwea[1] *= 7;
            _kwea[2] *= 2;
            _lfd *= 3;

            int _sum = _geburtsdatum[0] + _geburtsdatum[1] + _geburtsdatum[2] + _geburtsdatum[3] + _geburtsdatum[4] + _geburtsdatum[5] + _nachname + _kwea[0] + _kwea[1] + _kwea[2] + _lfd;
            int _mod = _sum % 11;
            int _diff = 11 - _mod;

            switch (_diff)
            {
                case 10:
                    return 0;

                case 11:
                    return 1;

                default:
                    return _diff;
            }
        }
    }
}
