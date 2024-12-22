using QuizLogic.Models;

namespace Quiz
{
    public static class Display
    {
        static List<string> akceptowalneKlawisze = ["1", "2", "3", "4"];

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
            var odpowiedz = WyswietlPytanie(pytanie);
            while(!akceptowalneKlawisze.Contains(odpowiedz))
            {
                odpowiedz = WyswietlPytanie(pytanie);
            }

            return int.Parse(odpowiedz);
        }

        private static string WyswietlPytanie(Pytanie pytanie)
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
            return Console.ReadLine()!;
        }



        public static void KoniecGry()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Niestety to nie jest prawidłowa odpowiedź");
            Console.WriteLine();
            Console.WriteLine(" KONIEC GRY");
        }

        public static void OdpowiedzOk(int punkty)
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Brawo,  to jest prawidłowa odpowiedź !!!");
            Console.WriteLine($" Zdobyłaś/eś {punkty} pkt.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Naciśnij ENTER - aby zobaczyć następne pytanie ...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
        }

        public static void Wygrana()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Brawo, to było ostatnie pytanie !!!");
            Console.WriteLine($" Wygrałaś/eś QUIZ !!!");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
