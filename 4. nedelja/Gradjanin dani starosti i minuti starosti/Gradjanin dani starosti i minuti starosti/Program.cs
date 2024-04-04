// See https://aka.ms/new-console-template for more information
using Gradjanin_dani_starosti_i_minuti_starosti;

Console.WriteLine("u kalsi gradjanin dodati jos dve metode DaniStarosti() i MinutiStarosti()!");
Console.WriteLine("Omoguciti korisniku da za unete podakte o dve osobe vidi datume rodjenja bez (00:00;00)");
Console.WriteLine("i da vidi koliko je ko od njih star u danima i minutima");

Console.WriteLine("Unesi prvog gradjanina");
string gra1 = Console.ReadLine();
Console.WriteLine("Unesi drugog gradjanina");
string gra2 =Console.ReadLine();
string[] niz1 = gra1.Split(' ');
string[] niz2 = gra2.Split(' ');

Gradjanin g1 = new Gradjanin(niz1[0], niz1[1], niz1[2]);
Gradjanin g2 = new Gradjanin(niz2[0], niz2[1], niz2[2]);

Console.WriteLine(g1.Ime_Get() + "\t" + g1.KonvertDana().ToShortDateString() + "\t" + g1.DaniStarosti()+ "-dana\t" + g1.MinutiStarosti()+"-minuta");
Console.WriteLine(g2.Ime_Get() + "\t" + g2.KonvertDana().ToShortDateString() + "\t" + g2.DaniStarosti() + "-dana\t" + g2.MinutiStarosti()+ "-minuta" );
