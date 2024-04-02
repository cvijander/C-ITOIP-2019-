// See https://aka.ms/new-console-template for more information
Console.WriteLine("Korisink unosi realne broj dok ne unese jedan negativan ");
Console.WriteLine("Program ispisuje zbir sviuh pozitivnih brojeva, koliko ih ima i njihov prosek ");

Console.WriteLine("Unesite pozitivni broj ili negativni za prekid rada");
float broj = float.Parse(Console.ReadLine());
float zbir=0;
int ukupnoBrojeva = 0;

while (broj >0)
{
    zbir += broj;
    ukupnoBrojeva++;

    broj = float.Parse(Console.ReadLine());
}

Console.WriteLine("Ukupno brojeva " +ukupnoBrojeva);
Console.WriteLine("Zbir " +zbir );
Console.WriteLine("Prosek " + zbir /ukupnoBrojeva);
