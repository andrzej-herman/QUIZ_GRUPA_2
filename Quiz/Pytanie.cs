namespace Quiz
{
    public class Pytanie
    {
        public int Id { get; set; }
        public string Tresc { get; set; }
        public int Kategoria { get; set; }
        public string Odpowiedz_1 { get; set; }
        public string Odpowiedz_2 { get; set; }
        public string Odpowiedz_3 { get; set; }
        public string Odpowiedz_4 { get; set; }


        public int DodajDwieLiczbyCalkowite(int a, int b)
        {
            return a + b;
        }

        public bool SprawdzCzyLiczbaJestParzysta(int liczba)
        {
            return liczba % 2 == 0;
        }

        public void NapiszDupa()
        {
            Console.WriteLine("DUPA");
        }

    }
}
