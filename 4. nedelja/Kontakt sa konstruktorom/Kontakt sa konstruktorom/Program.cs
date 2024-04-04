// See https://aka.ms/new-console-template for more information
using Kontakt_sa_konstruktorom;

Console.WriteLine("U klasi dodati konstruktor koji sve podatke unosi u jednom redu");
Console.WriteLine("Omoguciti korisniku da unese 5 kontakt u listu i da ih nakon toga sve prikaze");

List<Kontakt> listaKontakt= new List<Kontakt>();

for(int i=1; i<6; i++)
{
    Console.WriteLine("Unesi podatke za " +i+ " osbu ime prezime brtel email");
    string odg = Console.ReadLine();
    Kontakt k = new Kontakt (odg);
    listaKontakt.Add (k);

}

foreach (Kontakt kon in listaKontakt)
{
    Console.WriteLine(kon);
}
