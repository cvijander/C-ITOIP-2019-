// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pogodite broj");
int tajniBroj;
int broj;

Console.WriteLine("Unesite tajni broj ");
tajniBroj = int.Parse(Console.ReadLine());
for(int i =0; i<4; i++)
{
    Console.WriteLine("*** Pogodite tajni broj: ***");
    broj = int.Parse(Console.ReadLine());
    if(broj ==tajniBroj)
    {
        Console.WriteLine("Pogodili ste broj");
        break;
    }
    else if (broj > tajniBroj)
    {
        Console.WriteLine("Vas broj je veci od tajnog broja ");
        Console.WriteLine("Ostalo Vam je jos do sada " + (4-i) + " pokusaja");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Vas broj je manji od tajnog broja");
        Console.WriteLine("Ostalo Vam je jos do sada " + (4 - i) + " pokusaja");
        Console.WriteLine();
    }
}
Console.WriteLine("Kraj igre");

