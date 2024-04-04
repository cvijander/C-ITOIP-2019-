// See https://aka.ms/new-console-template for more information
using dva_kompleksna_broja;

Console.WriteLine("Omoguciti korisniku da unese dva kompleksa broja ");
Console.WriteLine("da napravi njhi zbir i da nakon toga da prikaze taj novi kompleksni broj ");
Console.WriteLine("ako je realan ili imaginaran deo tog broja nula izostaviti nulu iz prikaza");


Console.WriteLine("Unesi prvi kompleksni broj");
Console.WriteLine("x= ");
float x = float.Parse(Console.ReadLine());
Console.WriteLine("y= ");
float y = float.Parse(Console.ReadLine());
KompleX z1= new KompleX(x,y);
Console.WriteLine("Uneski drugi kompleksni broj");
Console.WriteLine("x= ");
x=float.Parse(Console.ReadLine());
Console.WriteLine("y= ");
y=float.Parse(Console.ReadLine());
KompleX z2= new KompleX(x, y);
KompleX zb = new KompleX();
zb.SaverBrojeve(z1, z2);
Console.WriteLine("Zbir " +zb);