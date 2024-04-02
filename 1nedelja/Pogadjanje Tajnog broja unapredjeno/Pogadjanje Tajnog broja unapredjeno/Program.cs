// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pogadjanje tajnog broja ");
Console.WriteLine("Princip je da se unese tajni broj a zatim korisnik unosi svoj broj, koji se poredi sa tajnim i daje mu rezutlat da li je tacan veci ili manji");

int tajniBroj;
int brojKojiKorisnikUnosi;
int max;
int min;
int trenutniBroj;
int brojac=0;

Console.WriteLine("Unesite tajni broj ");
tajniBroj = int.Parse(Console.ReadLine());

do
{
    
    Console.WriteLine("Unesite broj");
    brojKojiKorisnikUnosi = int.Parse(Console.ReadLine());
    
    min = brojKojiKorisnikUnosi;
    max =brojKojiKorisnikUnosi ;

    if (tajniBroj > brojKojiKorisnikUnosi)
    {
        Console.WriteLine("Tajni broj je veci  od ovog broja " + min);
        Console.WriteLine("Ne mozete unositi manji broj od " +min);
       
        brojac++;

    }
    else if (tajniBroj < brojKojiKorisnikUnosi )
    {
        Console.WriteLine("Tajni broj je manji od ovog broja " + max);
        Console.WriteLine("Ne mozete unositi veci broj od " + max);

        brojac++;
    }
    else
    {
        Console.WriteLine("Pogodili ste tajni broj je " +tajniBroj);
        Console.WriteLine("Uspeli ste nakon " + brojac + " pokusaja.");
        break;
    }

} while (tajniBroj != brojKojiKorisnikUnosi);
Console.WriteLine("Kraj igre");



