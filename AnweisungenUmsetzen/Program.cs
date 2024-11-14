using System;

namespace AnweisungenUmsetzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie Ihren Vor - und Nachnamen ein:");
            string name = Console.ReadLine();

            //checkt die auf dem System eingestellte Zeit.
            DateTime date = DateTime.Now;
            int stunde = date.Hour; //kann aufgeteilt werden in year, Month, Day, Hour, Minute, Second, Millisecond.

            //prüft ob etwas im string begruessung zurückgegeben wurde.
            string begruessung = ErmittleBegruessung(stunde);
            if (!string.IsNullOrEmpty(begruessung))
            {
                Console.WriteLine($"{begruessung} {name}");
            }
            else
            {
                Console.WriteLine("Keine Uhrzeit gefunden");
            }
        }

        public static string ErmittleBegruessung(int stunde)
        {
            if (stunde >= 5 && stunde <= 10) //Von 05:00 Uhr bis 10:59 Uhr: Guten Morgen
            {
                return "Guten Morgen";
            }
            else if (stunde >= 11 && stunde <= 16) //Von 11:00 Uhr bis 16:59 Uhr: Guten Tag
            {
                return "Guten Tag";
            }
            else if (stunde >= 17 && stunde <= 22)// Von 17:00 Uhr bis 22:59 Uhr: Guten Abend
            {
                return "Guten Abend";
            }
            else if ((stunde == 23) || (stunde >= 0 && stunde <= 4)) //Von 23:00 Uhr bis 04:59 Uhr: Gute Nacht
            {
                return "Gute Nacht";
            }
            else
            {
                //gibt leeren string zurück
                return string.Empty;
            }
        }
    }
}
