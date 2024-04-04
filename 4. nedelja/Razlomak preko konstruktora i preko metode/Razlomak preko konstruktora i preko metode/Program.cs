// See https://aka.ms/new-console-template for more information
using Razlomak_preko_konstruktora_i_preko_metode;

Console.WriteLine("Omoguciti korisniku da  sam odabere 2 razlomka, jednog preko konstruktora");
Console.WriteLine("drugog preko Set metode zatim omoguciti da se proveri unos");
Console.WriteLine("i u set metodama i u kosntruktoru");
Console.WriteLine("klasi razlomak dodati metodu ToString() koja ce omoguciti prikaz razlomka");


Razlomak r = new Razlomak();
Console.WriteLine("Prvi razlomak");
r.CeoBroj_Set(int.Parse(Console.ReadLine()));
r.Brojilac_Set(int.Parse(Console.ReadLine()));
r.Imenilac_Set(int.Parse(Console.ReadLine()));
Console.WriteLine("Drugi razlomak");
int ceo = int.Parse(Console.ReadLine());
int bro = int.Parse(Console.ReadLine());
int ime= int.Parse(Console.ReadLine());
Razlomak r2 = new Razlomak(ceo,bro,ime);
Console.WriteLine("Primblizna vrednost 1. razlomka " + r.PribliznaVrednost());
Console.WriteLine("Priblizna vrednosto 2. razlmoka " +r.PribliznaVrednost());
Console.WriteLine(r);
Console.WriteLine(r2);
