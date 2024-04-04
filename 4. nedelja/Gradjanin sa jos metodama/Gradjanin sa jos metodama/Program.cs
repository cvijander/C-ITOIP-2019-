// See https://aka.ms/new-console-template for more information
using Gradjanin_sa_jos_metodama;

Console.WriteLine("Omoguciti korisniuku da za unete podatke o dve osobe ");
Console.WriteLine("vidi njihovo godiste i datume rodjenja u formatu DateTime");

Console.WriteLine("Unesi prvog gradjaninia ");
string odg1 = Console.ReadLine();
Console.WriteLine("Unesi drugog grajanainna ");
string odg2 =Console.ReadLine();

string[] niz1 = odg1.Split(' ');
string[] niz2 = odg1.Split(' ');

Gradjanin g1 = new Gradjanin(niz1[0], niz1[1], niz1[2]);
Gradjanin g2 = new Gradjanin(niz2[0], niz2[1], niz2[2]);

Console.WriteLine(g1.Ime_Get()+ "\t" + g1.Godiste()+ ".-godiste\t" +g1.KonvDat()) ;
Console.WriteLine(g2.Ime_Get() + "\t" +g2.Godiste()+ ".-godiste\t" +g2.KonvDat());
