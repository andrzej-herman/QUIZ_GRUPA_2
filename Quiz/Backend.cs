using System.Text.Json;

namespace Quiz
{
    public class Backend
    {
        Random _random;

        public Backend()
        {
            _random = new Random();
            UtworzBazePytan();
            Kategorie = BazaPytan.Select(x => x.Kategoria).Distinct().OrderBy(p => p).ToList();
            AktualnaKategoria = Kategorie[AktualnyIndex];
        }

        public int AktualnyIndex { get; set; }
        public List<int> Kategorie { get; set; }
        public List<Pytanie>? BazaPytan { get; set; }
        public int AktualnaKategoria { get; set; }
        public Pytanie AktualnePytanie { get; set; }

        public void UtworzBazePytan()
        {
            var sciezka = $"{Directory.GetCurrentDirectory()}\\questions_pl.json";
            var json = File.ReadAllText(sciezka);
            BazaPytan = JsonSerializer.Deserialize<List<Pytanie>>(json);          
        }

        public void WylosujPytanieZDanejKategorii()
        {
            var dobrePytania = BazaPytan.Where(x => x.Kategoria == AktualnaKategoria).ToList();
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
            var maxIndex = Kategorie.Count - 1;
            return AktualnyIndex == maxIndex;     
        }

        public void PoniesKategorie()
        {
            AktualnyIndex++;
            AktualnaKategoria = Kategorie[AktualnyIndex];
        }
    }
}
