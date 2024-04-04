// See https://aka.ms/new-console-template for more information
using Razlomak;

Console.WriteLine("Hello, World!");


RazlomakR raz = new RazlomakR();
raz.CeoBroj_Set(2);
raz.Imenilac_Set(7);
raz.Brojilac_Set(3);
Console.WriteLine("Priblizna vrdnosti: " + raz.PribliznaVrednost());
Console.WriteLine(raz);
