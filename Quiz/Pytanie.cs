namespace Quiz
{
    public class Pytanie
    {
        public int Id { get; set; }
        public string Tresc { get; set; }
        public int Kategoria { get; set; }
        public List<Odpowiedz> Odpowiedzi { get; set; } = [];
    }
}
