// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Program ispisuje sve prirodne brojeve manje od unetog");

Console.WriteLine("Unesite broj");
int broj =int.Parse(Console.ReadLine());
PrikaziSveManje(broj);


static void PrikaziSveManje(int number)
{
    int i = 1;
    while (i < number)
    {
        Console.Write(i + " ");
        i++;
    }
}
