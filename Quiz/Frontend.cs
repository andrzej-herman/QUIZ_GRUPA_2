using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public static class Frontend
    {
        public static void PokazEkranPowitalny()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine(" WITAJ W APLIKACJI QUIZ");
            Console.WriteLine();
            Console.WriteLine(" SPRÓBUJ ODPOWIEDZIEĆ NA 7 PYTAŃ - WÓWCZAS WYGRASZ QUIZ");
            Console.WriteLine();
            Console.WriteLine(" POWODZENIA !!!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Naciśnij ENTER, aby rozpocząć grę ...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

        public static int WyswietlPytanieIDajOdpowiedzGracza(Pytanie pytanie)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine($" Pytanie za {pytanie.Kategoria} pkt.");
            Console.WriteLine();
            Console.WriteLine($" {pytanie.Tresc}");
            Console.WriteLine();
            foreach (var odpowiedz in pytanie.Odpowiedzi)
                Console.WriteLine($" {odpowiedz.Id}. {odpowiedz.Tresc}");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Naciśnij 1, 2, 3 lub 4 = aby udzielić odpowiedzi ...  ");
            Console.ForegroundColor = ConsoleColor.White;
            return int.Parse(Console.ReadLine());
        }
    }
}
