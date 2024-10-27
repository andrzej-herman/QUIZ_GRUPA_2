using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Backend
    {
        public List<Pytanie> BazaPytan { get; set; }

        public void UtworzBazePytan()
        {
            BazaPytan = new List<Pytanie>();
            var p1 = new Pytanie();
            p1.Id = 1;
            p1.Kategoria = 100;
            p1.Tresc = "Jak miał na imię Eintein?";
            p1.Odpowiedz_1 = "Albert";
            p1.Odpowiedz_2 = "Aaron";
            p1.Odpowiedz_3 = "Leszek";
            p1.Odpowiedz_4 = "Tomek";
            BazaPytan.Add(p1);

            var p2 = new Pytanie();
            p2.Id = 2;
            p2.Kategoria = 200;
            p2.Tresc = "Ile jest w Polsce województw?";
            p2.Odpowiedz_1 = "16";
            p2.Odpowiedz_2 = "49";
            p2.Odpowiedz_3 = "26";
            p2.Odpowiedz_4 = "15";
            BazaPytan.Add(p2);
        }
    }
}
