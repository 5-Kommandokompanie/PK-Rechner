using System;

namespace PK_Rechner
{
	public static class Nachname
	{
		public static char Buchstabe { get; set; }

		public static int Eingabe()
		{
			Console.Write("Erster Buchstabe Nachname: ");
			char nachname = Convert.ToChar(Console.ReadLine());
			Buchstabe = nachname;

			switch (nachname) //Zuweisung des Buchstabens des Nachnamens zu einer Zahl
			{
				case 'A':
					return 12;
				case 'B':
					return 14;
				case 'C':
					return 16;
				case 'D':
					return 18;
				case 'E':
					return 20;
				case 'F':
					return 22;
				case 'G':
					return 24;
				case 'H':
					return 26;
				case 'I':
					return 28;
				case 'J':
					return 6;
				case 'K':
					return 8;
				case 'L':
					return 10;
				case 'M':
					return 12;
				case 'N':
					return 14;
				case 'O':
					return 16;
				case 'P':
					return 18;
				case 'Q':
					return 20;
				case 'R':
					return 22;
				case 'S':
					return 4;
				case 'T':
					return 6;
				case 'U':
					return 8;
				case 'V':
					return 10;
				case 'W':
					return 12;
				case 'X':
					return 14;
				case 'Y':
					return 16;
				case 'Z':
					return 18;
				default:
					return 0;
			}
		}
	}
}
