// See https://aka.ms/new-console-template for more information
using Kontakt;

Console.WriteLine("Kreirati klasu kontakt sa atributima ime prezime br tel i email !");
Console.WriteLine("napraviti get i set metode i konstruktor i to string metodu");
Console.WriteLine("omoguciti korisniku da unese 3 kontakt i da ih noako toga pokaze");


Console.WriteLine("Unesi podatke za 1 osobu (ime, prezime, brtel, email)");
string odgvor=Console.ReadLine();
string[] niz = odgvor.Split(' ');
KontaktK k1 = new KontaktK(niz[0], niz[1], niz[2], niz[3]);
Console.WriteLine("Unesite podatke za srugu osobu");
odgvor = Console.ReadLine();
niz = odgvor.Split(' ');
KontaktK k2 = new KontaktK(niz[0], niz[1], niz[2], niz[3]);
Console.WriteLine("Unesite podastke za trecu osobu");
odgvor =Console.ReadLine();
niz = odgvor.Split(' ');
KontaktK k3 = new KontaktK(niz[0], niz[1], niz[2], niz[3]);
Console.WriteLine(k1);
Console.WriteLine(k2);
Console.WriteLine(k3);
