/*
 * Created by SharpDevelop.
 * User: Lenn
 * Date: 22.05.2024
 * Time: 09:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text.RegularExpressions;
using System.IO;

namespace msg_David_Sprint__Tag_1_
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Guten Tag!");
			int i = 0;
			String Gleichzeichen = "==========================";
			int AnzahlUnterkurse = 0;
			// TODO: Implement Functionality Here
			int Fach1, Fach2, Fach3, Fach4, Fach5, Fach6, Fach7, Fach8;
			
			Double Notendurchschnitt;
			String Name;
			DateTime Datum = DateTime.Now;
			int Fehltage;
			int unentschuldigteFehltage;
			
			while (true)
            {
                Console.Write("Name des Schülers: ");
                Name = Console.ReadLine();
                if (Regex.IsMatch(Name, @"^[a-zA-Z\s-]+$"))
                {
                    break;
                }
                Console.WriteLine("Ungültiger Name! Der Name darf nur Buchstaben, Leerzeichen und Bindestriche enthalten.");
			}
			Console.WriteLine();
			Console.Write("Fehltage: ");
			Fehltage = Convert.ToInt32(Console.ReadLine());
			Console.Write("Davon unentschuldigt: ");
			unentschuldigteFehltage = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			Console.Write("Wie viele Punkte in Leistungkurs Informatik? ");
			Fach1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Wie viele Punkte in Leistungskurs Mathematik? ");
			Fach2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Wie viele Punkte in Englisch? ");
			Fach3 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Wie viele Punkte in Politik? ");
			Fach4 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Wie viele Punkte in Deutsch? ");
			Fach5 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Wie viele Punkte in Geschichte? ");
			Fach6 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Wie viele Punkte in Kunst? ");
			Fach7 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Wie viele Punkte in Sport? ");
			Fach8 = Convert.ToInt32(Console.ReadLine());
			Notendurchschnitt = Convert.ToDouble((Fach1 *2 + Fach2 *2 + Fach3+Fach4+Fach5+Fach6+Fach7+Fach8)/10);
			Math.Round(Notendurchschnitt,1);
			
			if (Notendurchschnitt > 15 || Fach1 > 15 || Fach2 > 15 || Fach3 > 15 || Fach4 > 15 || Fach5 > 15 || Fach6 > 15 || Fach7 > 15 || Fach8 > 15)
			{
				Console.Write("Error. Noteneingabe ist nicht Korrekt.");
				Console.ReadKey(true);
				return;
			}
			else
			{
			Console.WriteLine(Gleichzeichen);
			Console.WriteLine("Zeugnis:");
			Console.WriteLine();
			Console.WriteLine(Datum);
			Console.WriteLine("David-Gymnasium");
			Console.WriteLine(Convert.ToString(Name));
			Console.WriteLine(Gleichzeichen);
			Console.WriteLine();
			
			Console.Write("Fehltage: ");
			Console.WriteLine(Fehltage);
			Console.Write("Davon unentschuldigt: ");
			Console.WriteLine(unentschuldigteFehltage);
			Console.WriteLine();
			Console.WriteLine(Gleichzeichen);
			Console.WriteLine();
			Console.WriteLine();
			
			Console.WriteLine("Naturwissenschaften:");
			Console.WriteLine();
			Console.Write("Infornote	:	");
			Console.WriteLine(Fach1);
			Console.WriteLine();
			Console.Write("Mathenote	:	");
			Console.WriteLine(Fach2);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Sprachen:");
			Console.WriteLine();
			Console.Write("Deutschnote	:	");
			Console.WriteLine(Fach5);
			Console.WriteLine();
			Console.Write("Englischnote	:	");
			Console.WriteLine(Fach3);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Gesellschaftlich:");
			Console.WriteLine();
			Console.Write("Geschichtsnote	:	");
			Console.WriteLine(Fach6);
			Console.WriteLine();
			Console.Write("Politiknote	:	");
			Console.WriteLine(Fach4);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Musisch-Künstlerisch:");
			Console.WriteLine();
			Console.Write("Kunstnote	:	");
			Console.WriteLine(Fach7);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Sport:");
			Console.WriteLine();
			Console.Write("Sportnote	:	");
			Console.WriteLine(Fach8);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(Gleichzeichen);
			Console.WriteLine();
			Console.WriteLine();
			
			string zeugnis = Datum + "\n" +
                             "David-Gymnasium\n" +
                             Name + "\n\n" +
                             "Fehltage: " + Fehltage + "\n" +
                             "Davon unentschuldigt: " + unentschuldigteFehltage + "\n\n" +
                             "Naturwissenschaften:\n\n" +
                             "Informatiknote: " + Fach1 + "\n\n" +
                             "Mathematiknote: " + Fach2 + "\n\n" +
                             "Sprachen:\n\n" +
                             "Deutschnote: " + Fach5 + "\n\n" +
                             "Englischnote: " + Fach3 + "\n\n" +
                             "Gesellschaftlich: \n\n" +
                             "Geschichtsnote: " + Fach6 + "\n\n" +
                             "Politiknote: " + Fach4 + "\n\n" +
                             "Musisch-Künstlerisch:\n\n" +
                             "Kunstnote: " + Fach7 + "\n\n" +
                             "Sport:\n\n" +
                             "Sportnote: " + Fach8 + "\n\n";
			
			int [] UnterkursArray = new int[] {Fach1,Fach2,Fach3,Fach4,Fach5,Fach6,Fach7,Fach8};
			int Vergleichszahl = 5;
			for (i = 0; i < UnterkursArray.Length; i++)
			{
				if (UnterkursArray [i] < Vergleichszahl)
				{
					AnzahlUnterkurse = AnzahlUnterkurse + 1;
				}
			}
			
			if (Notendurchschnitt > 5)
			{
				if (unentschuldigteFehltage > 30)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Der Schüler wird nicht versetzt.");
					Console.ForegroundColor = ConsoleColor.Gray;
					Console.Write("Der Notendurschnitt beträgt: ");
					Console.Write(Notendurchschnitt.ToString());
					Console.WriteLine();
					Console.WriteLine("Der Schüler verzeichnet zu viele unentschuldigte Fehltage.");
					zeugnis += "Der Schüler wird nicht versetzt.\n" +
                               "Der Notendurschnitt beträgt: " + Notendurchschnitt + "\n" +
                               "Der Schüler verzeichnet zu viele unentschuldigte Fehltage.\n";
					Console.WriteLine();
					Console.ReadKey(true);
				}
				if (AnzahlUnterkurse > 2)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Der Schüler wird nicht versetzt.");
					Console.ForegroundColor = ConsoleColor.Gray;
					Console.Write("Der Notendurschnitt beträgt: ");
					Console.Write(Notendurchschnitt.ToString());
					Console.ReadLine();
					Console.WriteLine("Der Schüler verzeichnet zu viele Unterkurse.");
					zeugnis += "Der Schüler wird nicht versetzt.\n" +
                               "Der Notendurschnitt beträgt: " + Notendurchschnitt + "\n" +
                               "Der Schüler verzeichnet zu viele Unterkurse.\n";
					Console.WriteLine();
					Console.ReadKey(true);
				}
				else 
				{
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Der Schüler wird versetzt.");
					Console.ForegroundColor = ConsoleColor.Gray;
					Console.Write("Der Notendurschnitt beträgt: ");
					Console.Write(Notendurchschnitt.ToString());
					Console.WriteLine();
					zeugnis += "Der Schüler wird versetzt.\n" +
                               "Der Notendurschnitt beträgt: " + Notendurchschnitt + "\n";
					Console.WriteLine();
					Console.ReadKey(true);
				}
			}	
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Der Schüler wird nicht versetzt.");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write("Der Notendurschnitt beträgt: ");
				Console.Write(Notendurchschnitt.ToString());
				Console.WriteLine();
				Console.WriteLine("Der Schüler verzeichnet einen zu niedrigen Notendurchschnitt");
				zeugnis += "Der Schüler wird nicht versetzt.\n" +
                           "Der Notendurschnitt beträgt: " + Notendurchschnitt + "\n" +
                           "Der Schüler verzeichnet einen zu niedrigen Notendurchschnitt\n";
				Console.WriteLine();
				Console.ReadKey(true);
			}
			Console.WriteLine("Soll das Zeugnis als Textdatei ausgegeben werden? (Ja/Nein): ");
			string antwort = Console.ReadLine();
			Console.WriteLine();
			if (antwort == "Ja")
			{
				string fileName = Name.Replace(" ", "_").Replace("-", "_") + "_Zeugnis.txt";
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
                FileStream Textdatei = File.Create(filePath);
                Textdatei.Close();
                File.WriteAllText(filePath, zeugnis);
                Console.WriteLine("Das Zeugnis wurde in der Datei " + filePath + " gespeichert.");
			}
			else
            {
                Console.WriteLine("Das Zeugnis wurde nicht gespeichert.");
            }
            Console.ReadKey(true);
			}
		}
	}
}