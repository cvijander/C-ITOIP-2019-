// See https://aka.ms/new-console-template for more information
using komplex_broj;

Console.WriteLine("napisati klasu kompex koja cuva zapis komplekson broja");
Console.WriteLine("atributi su x realni broj i y imaginarni deo");
Console.WriteLine("dodati konstruktorew getmetode pod nazivom re i im i metodu to string ");
Console.WriteLine("omgucti korisniku da unese kompleksi broj i da ga prikaze ");

Console.WriteLine("Unesi kompleksni broj");
Console.WriteLine("X= ");
float x = float.Parse(Console.ReadLine());
Console.WriteLine("y= ");
float y = float.Parse(Console.ReadLine());
KompleX z = new KompleX(x, y);
Console.WriteLine("z= " +z);

