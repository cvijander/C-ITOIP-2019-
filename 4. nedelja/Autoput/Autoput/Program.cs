// See https://aka.ms/new-console-template for more information
using Autoput;

Console.WriteLine("Napisati klasu autoput sa atributoima gradA(string) gradB(string) duzina(float)");
Console.WriteLine("kalsi dodati konstruktor i metodu ToString sa formatom ispisa 'Autoput Beograd - Nis 235km");
Console.WriteLine("omoguciti korisniku da unese autoput i da mu se uneti podaci ponovo prikazu");

Console.WriteLine("Unesi prvi grad");
string gradA=Console.ReadLine();
Console.WriteLine("Unesi drugi grad");
string gradB=Console.ReadLine();
Console.WriteLine("Unesi razdaljniu");
float duzina =float.Parse(Console.ReadLine());
AutoputA a = new AutoputA(gradA, gradB, duzina);
Console.WriteLine(a);
