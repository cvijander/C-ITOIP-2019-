// See https://aka.ms/new-console-template for more information
Console.WriteLine("Postovani korisnice unesite cenu, a zatim i broj meseci");
Console.WriteLine("Nakon toga program ce Vam reci da li trosite manje ili vise od 10000 ");




int ponovo = 0;
do
{
    Console.Write("Unesite cenu: ");
    double cena = double.Parse(Console.ReadLine());
    Console.Write("Unesite mesece: ");
    int meseci = int.Parse(Console.ReadLine());
    int godina;
    int meseciOdGodine;
    godina = meseci / 12;
    meseciOdGodine = meseci % 12;
    
    double rezultat = cena * meseci;
    if (rezultat > 10000)
    {
        Console.WriteLine("Placate previse");
        Console.WriteLine("Za vremene od " + godina + " godina i meseci " +meseciOdGodine  );
    }
    else if (rezultat <= 10000)
    {
        Console.WriteLine("Trosite taman koliko treba");
        Console.WriteLine("Za vremene od " + godina + " godina i meseci " + meseciOdGodine);

    }
    Console.WriteLine("Da li zelite ponovo ?  1-DA , 2 - NE");
    ponovo = int.Parse(Console.ReadLine());
} while (ponovo == 1);
