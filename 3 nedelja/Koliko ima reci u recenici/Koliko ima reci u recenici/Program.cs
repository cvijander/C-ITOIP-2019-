// See https://aka.ms/new-console-template for more information
Console.WriteLine("Na kraci nacin napisati koliko ima reci u recenici");

Console.WriteLine("Unesite recenicu ");
string recenica =Console.ReadLine();

string[] reci = recenica.Split(' ', ',' ,'.' );
// danas  je nedelja 
// reci[0] =danas 
// reci[1] = je
// reci[2] = nedelja

int ukupnoReci = reci.Length;
foreach (string  item in reci)
{
    if (item == "") ukupnoReci--;
}
Console.WriteLine("Ukupno ima "+ ukupnoReci+ " reci ");

