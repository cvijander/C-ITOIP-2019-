// See https://aka.ms/new-console-template for more information
using Klasa_sa_metodama;

Console.WriteLine("Napisati klasu covek koja ima metodu PozdraviSvet , metodu Ime_Get koja dozvoljava ime do 25 karaktera ");
Console.WriteLine("I metodu Prezime_Get koja dozvoljava prezime do 35 karaktera");
Console.WriteLine("Nakon toga u glavnom programu kreirati 2 obekta kalse ");

Covek a = new Covek();
a.Ime_Set("Rafele");
a.Prezime_Set("Nadal");
a.PozdraviSvet();

Covek b = new Covek();
b.Ime_Set("Novak ");
b.Prezime_Set("Djokovci");
b.PozdraviSvet();


