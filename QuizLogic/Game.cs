using QuizLogic.Models;
using System.Text.Json;

namespace QuizLogic
{
    public class Game
    {
        Random _random;
        int _aktualnyIndex;
        List<int> _kategorie;
        List<Pytanie> _questions;

        public Game()
        {
            _random = new Random();
            UtworzBazePytan();
            UtworzKategorie();
        }

        public int AktualnaKategoria { get; set; }
        public Pytanie AktualnePytanie { get; set; }

        private void UtworzKategorie()
        {
            _kategorie = _questions.Select(x => x.Kategoria).Distinct().OrderBy(p => p).ToList();
            AktualnaKategoria = _kategorie[_aktualnyIndex];
        }

        private void UtworzBazePytan()
        {
            var sciezka = $"{Directory.GetCurrentDirectory()}\\questions_pl.json";
            var json = File.ReadAllText(sciezka);
            _questions = JsonSerializer.Deserialize<List<Pytanie>>(json);          
        }

        public void WylosujPytanieZDanejKategorii()
        {
            var dobrePytania = _questions.Where(x => x.Kategoria == AktualnaKategoria).ToList();
            var number = _random.Next(0, dobrePytania.Count);
            var pytanie = dobrePytania[number];
            pytanie.Odpowiedzi = pytanie.Odpowiedzi.OrderBy(p => _random.Next()).ToList();
            var id = 1;
            foreach (var a in pytanie.Odpowiedzi)
            {
                a.Id = id++;
            }

            AktualnePytanie = pytanie;
        }

        public bool CzyGraczOdpowiedzialPoprawnie(int odpowiedzGracza)
        {
            var odpowiedz = AktualnePytanie.Odpowiedzi
                .FirstOrDefault(o => o.Id == odpowiedzGracza);

            return odpowiedz!.CzyPoprawna;
        }

        public bool CzyOstatniaKategoria()
        {
            var maxIndex = _kategorie.Count - 1;
            return _aktualnyIndex == maxIndex;     
        }

        public void PoniesKategorie()
        {
            _aktualnyIndex++;
            AktualnaKategoria = _kategorie[_aktualnyIndex];
        }
    }
}
