// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Korisnik unosi prirodne brojeve  u listu ");
Console.WriteLine("Sve dok ne unese jedan negativan ");
Console.WriteLine("Program ispisuje minumim i maximum brojeva ");

int broj = int.Parse(Console.ReadLine());
List<int> listaBrojeva = new List<int>();

while (broj > 0)
{
    listaBrojeva.Add(broj);
    broj =int.Parse(Console.ReadLine());
}

Console.WriteLine("Max je " + listaBrojeva.Max());
Console.WriteLine("Min je " + listaBrojeva.Min());
