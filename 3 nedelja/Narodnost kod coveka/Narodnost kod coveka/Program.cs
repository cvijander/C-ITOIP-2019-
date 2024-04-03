// See https://aka.ms/new-console-template for more information
using Narodnost_kod_coveka;

Console.WriteLine("U klasi covek dodati polje za narodnost a umesto metode PozdraviSvet() napisati metodu PozdravNaMaternjemJeziku() ");
Console.WriteLine("U kojem razlikujemo tri jezika srpski, engleski, i spanski ");
Console.WriteLine(" i cetvrti slucaj ako se desila greska kod unosa imena ili prezimena");


Covek a = new Covek();
Console.WriteLine("Ime osobe");
a.Ime_set(Console.ReadLine());
Console.WriteLine("Prezime osobe");
a.Prezime_set(Console.ReadLine());
Console.WriteLine("Narodnost");
a.Narodnost_set(Console.ReadLine());
a.PozdravNaMaternjemJeziku();
