using Quiz;

// powołujemy do życia obiekt klasy Backend w którym będzie logika gry
// stworzenie bazy pytań  i ustawienie kategorii na pierwszą
// jest w konstruktorze klasy Backend
var backend = new Backend();

// wyświetlamy ekran powitalny
Frontend.PokazEkranPowitalny();

// wylosowanie pytania z najniższej kategorii
backend.WylosujPytanieZDanejKategorii();

// wyświetlenie pytania i pobranie odpowiedzi gracza
var odpowiedzGracza = Frontend.WyswietlPytanieIDajOdpowiedzGracza(backend.AktualnePytanie);

// walidacja odpowiedzi gracza
var czyGraczOdpowiedzialPoprawnie = backend.CzyGraczOdpowiedzialPoprawnie(odpowiedzGracza);

if (czyGraczOdpowiedzialPoprawnie)
{
    Console.WriteLine(" HURRA !!!!");
}
else
{
    Console.WriteLine(" BŁAD !!!!");
}

Console.ReadLine();