using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK_Rechner_WPF
{
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
}
