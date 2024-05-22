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

namespace msg_David_Sprint__Tag_1_
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Guten Tag!");
			
			// TODO: Implement Functionality Here
			Double Fach1, Fach2, Fach3, Fach4, Fach5, Fach6, Fach7, Fach8;
			Double Notendurchschnitt;
			String Name;
			String Datum;
			int Fehltage;
			int unentschuldigteFehltage;
			Console.Write("Name des Schülers: ");
			Name = Console.ReadLine();
			if (!Regex.IsMatch(Name, @"^[a-zA-Z]")) 
			{
				Console.Write("Ungültiger Name!");
				Console.ReadKey(true);
			}
			Console.Write("Datum: ");
			Datum = Console.ReadLine();
			Console.WriteLine();
			Console.Write("Fehltage: ");
			Fehltage = Convert.ToInt32(Console.ReadLine());
			Console.Write("Davon unentschuldigt: ");
			unentschuldigteFehltage = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			Console.Write("Wie viele Punkte in Leistungkurs Informatik? ");
			Fach1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Wie viele Punkte in Leistungskurs Mathematik? ");
			Fach2 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Wie viele Punkte in Englisch? ");
			Fach3 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Wie viele Punkte in Politik? ");
			Fach4 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Wie viele Punkte in Deutsch? ");
			Fach5 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Wie viele Punkte in Geschichte? ");
			Fach6 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Wie viele Punkte in Kunst? ");
			Fach7 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Wie viele Punkte in Sport? ");
			Fach8 = Convert.ToDouble(Console.ReadLine());
			Notendurchschnitt = Math.Round((Fach1 *2 + Fach2 *2 + Fach3+Fach4+Fach5+Fach6+Fach7+Fach8)/10,1);
			
			
			if (Notendurchschnitt > 15)
			{
				Console.Write("Error. Noteneingabe ist nicht Korrekt.");
				Console.ReadKey(true);
			}
			if (Fach1 > 15)
			{
				Console.Write("Error. Noteneingabe ist nicht Korrekt.");
				Console.ReadKey(true);
			}
			if (Fach2 > 15)
			{
				Console.Write("Error. Noteneingabe ist nicht Korrekt.");
				Console.ReadKey(true);
			}
			if (Fach3 > 15)
			{
				Console.Write("Error. Noteneingabe ist nicht Korrekt.");
				Console.ReadKey(true);
			}
			if (Fach4 > 15)
			{
				Console.Write("Error. Noteneingabe ist nicht Korrekt.");
				Console.ReadKey(true);
			}
			if (Fach5 > 15)
			{
				Console.Write("Error. Noteneingabe ist nicht Korrekt.");
				Console.ReadKey(true);
			}
			if (Fach6 > 15)
			{
				Console.Write("Error. Noteneingabe ist nicht Korrekt.");
				Console.ReadKey(true);
			}
			if (Fach7 > 15)
			{
				Console.Write("Error. Noteneingabe ist nicht Korrekt.");
				Console.ReadKey(true);
			}
			if (Fach8 > 15)
			{
				Console.Write("Error. Noteneingabe ist nicht Korrekt.");
				Console.ReadKey(true);
			}
			else
			{
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(Datum);
			Console.WriteLine("David-Gymnasium");
			Console.WriteLine(Convert.ToString(Name));
			Console.WriteLine();
			
			Console.Write("Fehltage: ");
			Console.WriteLine(Fehltage);
			Console.Write("Davon unentschuldigt: ");
			Console.WriteLine(unentschuldigteFehltage);
			Console.WriteLine();
			Console.WriteLine();
			
			Console.WriteLine("Naturwissenschaften:");
			Console.WriteLine();
			Console.Write("Informatiknote: ");
			Console.WriteLine(Fach1);
			Console.WriteLine();
			Console.Write("Mathematiknote: ");
			Console.WriteLine(Fach2);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Sprachen:");
			Console.WriteLine();
			Console.Write("Deutschnote: ");
			Console.WriteLine(Fach5);
			Console.WriteLine();
			Console.Write("Englischnote: ");
			Console.WriteLine(Fach3);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Gesellschaftlich:");
			Console.WriteLine();
			Console.Write("Geschichtsnote: ");
			Console.WriteLine(Fach6);
			Console.WriteLine();
			Console.Write("Politiknote: ");
			Console.WriteLine(Fach4);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Musisch-Künstlerisch:");
			Console.WriteLine();
			Console.Write("Kunstnote: ");
			Console.WriteLine(Fach7);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Sport:");
			Console.WriteLine();
			Console.Write("Sportnote: ");
			Console.WriteLine(Fach8);
			Console.WriteLine();
			
			if (Notendurchschnitt > 5)
			{
				if (unentschuldigteFehltage > 30)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Der Schüler wird nicht versetzt.");
					Console.ForegroundColor = ConsoleColor.Gray;
					Console.Write("Der Notendurschnitt beträgt: ");
					Console.Write(Notendurchschnitt.ToString());
					Console.ReadKey(true);
				}
				else 
				{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Der Schüler wird versetzt.");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write("Der Notendurschnitt beträgt: ");
				Console.Write(Notendurchschnitt.ToString());
				Console.ReadKey(true);
				}
			}	
			if (Notendurchschnitt < 5)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Der Schüler wird nicht versetzt.");
				Console.ForegroundColor = ConsoleColor.Gray;
				Console.Write("Der Notendurschnitt beträgt: ");
				Console.Write(Notendurchschnitt.ToString());
			}
			Console.ReadLine();
			}
		}
	}
}