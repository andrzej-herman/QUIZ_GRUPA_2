using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Backend
    {
        public Backend()
        {
            UtworzBazePytan();
            AktualnaKategoria = 100;
        }

        public List<Pytanie>? BazaPytan { get; set; }
        public int AktualnaKategoria { get; set; }
        public Pytanie AktualnePytanie { get; set; }

        public void UtworzBazePytan()
        {
            BazaPytan = new List<Pytanie>();
            var p1 = new Pytanie();
            p1.Id = 1;
            p1.Kategoria = 100;
            p1.Tresc = "Jak miał na imię Eintein?";
            var o1 = new Odpowiedz();
            o1.Id = 1;
            o1.Tresc = "Albert";
            o1.CzyPoprawna = true;
            p1.Odpowiedzi.Add(o1);

            var o2 = new Odpowiedz();
            o2.Id = 2;
            o2.Tresc = "Aaron";
            p1.Odpowiedzi.Add(o2);

            var o3 = new Odpowiedz();
            o3.Id = 3;
            o3.Tresc = "Leszek";
            p1.Odpowiedzi.Add(o3);

            var o4 = new Odpowiedz();
            o4.Id = 4;
            o4.Tresc = "Tomek";
            p1.Odpowiedzi.Add(o4);

            BazaPytan.Add(p1);
        }

        public void WylosujPytanieZDanejKategorii()
        {
            // symulujemy losowanie
            AktualnePytanie = BazaPytan!.FirstOrDefault()!;
        }

        public bool CzyGraczOdpowiedzialPoprawnie(int odpowiedzGracza)
        {
            var odpowiedz = AktualnePytanie.Odpowiedzi
                .FirstOrDefault(o => o.Id == odpowiedzGracza);

            return odpowiedz!.CzyPoprawna;
        }
    }
}
