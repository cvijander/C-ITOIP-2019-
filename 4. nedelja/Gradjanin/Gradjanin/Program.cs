// See https://aka.ms/new-console-template for more information
using Gradjanin;

Console.WriteLine("Napisati klasu gradjanin sa atributima jmbg ie prezime ");
Console.WriteLine("dodati konstruktor i metodu DatumRodjenja()");
Console.WriteLine("napisati glani progam u kojem korisnik unosi jednog gradjanina ");
Console.WriteLine("a progrma ispisuje njegov datum rodjenja");

Console.WriteLine("Unesi jmbg");
string jmbg= Console.ReadLine();
Console.WriteLine("Unesi ime");
string ime = Console.ReadLine();
Console.WriteLine("Unesi prezime");
string prezime = Console.ReadLine();
GradjaninG g = new GradjaninG(jmbg,ime,prezime);
Console.WriteLine("Odgovor: \nDatum rodjenja: " +g.DatumRodjenja());
