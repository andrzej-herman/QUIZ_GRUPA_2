using Quiz;
using QuizLogic;

// powołujemy do życia obiekt klasy Backend w którym będzie logika gry
// stworzenie bazy pytań  i ustawienie kategorii na pierwszą
// jest w konstruktorze klasy Backend
var game = new Game();

// wyświetlamy ekran powitalny
Display.PokazEkranPowitalny();

while (true)
{
    // wylosowanie pytania z najniższej kategorii
    game.WylosujPytanieZDanejKategorii();

    // wyświetlenie pytania i pobranie odpowiedzi gracza
    var odpowiedzGracza = Display.WyswietlPytanieIDajOdpowiedzGracza(game.AktualnePytanie);

    // walidacja odpowiedzi gracza
    var czyGraczOdpowiedzialPoprawnie = game.CzyGraczOdpowiedzialPoprawnie(odpowiedzGracza);

    if (czyGraczOdpowiedzialPoprawnie)
    {
        // ustalić czy to była ostatnia kategoria
        if (game.CzyOstatniaKategoria())
        {
            Display.Wygrana();
            break;
        }
        else
        {
            Display.OdpowiedzOk(game.AktualnaKategoria);
            // podnieść kategorię na nastepną
            game.PoniesKategorie();
        }
    }
    else
    {
        Display.KoniecGry();
        break;
    }
}



Console.ReadLine();