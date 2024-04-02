// See https://aka.ms/new-console-template for more information
Console.WriteLine("Korisnik unosi pozitivne prirodne brojeve sve dok ne unese neki negativan broj ");
Console.WriteLine("Program ispisuje min i max brojeva");

Console.WriteLine("Unesite broj");
int broj = int.Parse(Console.ReadLine());
int max = broj;
int min = broj;

while(broj > 0 )
{
    if( broj > max)
    {
        max = broj;
    }
    else if (broj < min )
    {
        min = broj;
    }

    broj = int.Parse(Console.ReadLine());
}
Console.WriteLine("Min= " + min + "  max = " + max);
