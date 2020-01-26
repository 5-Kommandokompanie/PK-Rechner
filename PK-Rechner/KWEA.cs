using System;

namespace PK_Rechner
{
    public static class KWEA
    {

        //Eingabe des Geburtsdatums
        public static int Eingabe()
        {
            Console.Write("Kreiswehrersatzamt (XXX): ");
            int kwea = Convert.ToInt32(Console.ReadLine());
            return kwea;
        }

        public static int[] Split(int kwea)
        {
            int[] _kwea = new int[3];
            //Aufspaltung in einzelne Ziffern
            _kwea[2] = kwea % 10;
            kwea /= 10;
            _kwea[1] = kwea % 10;
            kwea /= 10;
            _kwea[0] = kwea % 10;

            return _kwea;
        }
    }
}
