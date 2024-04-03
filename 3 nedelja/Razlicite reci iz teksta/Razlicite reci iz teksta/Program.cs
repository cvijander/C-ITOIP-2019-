// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Korisnik unosi teks u program");
Console.WriteLine("Progrma ispisuje sve razlicite reci iz teksta");
Console.WriteLine("Zajedno sa brojem ponavljanja");

Console.WriteLine("Unesi tekst: ");
string tekst=Console.ReadLine();

ArrayList reci = new ArrayList();
string[] niz = tekst.Split(' ', '.', ',');

int[] brojPojavljivanja = new int[niz.Length];

foreach(string r in niz)
{
    if(reci.Contains(r)) // ako rec vec postoji
    {
        brojPojavljivanja[reci.IndexOf(r)]++;
    }
    else  // ako je nova rec
    {
        reci.Add(r);
        brojPojavljivanja[reci.Count - 1] = 1;
    }
}

for(int i = 0;i< reci.Count;i++)
{
    Console.WriteLine(reci[i]+ "  - " + brojPojavljivanja[i]);
}
