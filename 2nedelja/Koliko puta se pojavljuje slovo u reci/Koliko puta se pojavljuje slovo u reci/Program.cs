// See https://aka.ms/new-console-template for more information
Console.WriteLine("Koliko puta se ponavlja slovo ");

Console.WriteLine("Unesite slovo koje zelite da se pretrazi ");
char slovo = char.Parse(Console.ReadLine());

Console.WriteLine("Unesite recenicu za koju zelite da se istrazi ");
string recenica =Console.ReadLine();

// pretvaramo recenicu u niz slova 
char[] slova = recenica.ToCharArray();
int brojac = 0;

foreach (char c in slova)
{
    if (c.Equals(slovo))
    {
        brojac++;
    }
}

Console.WriteLine( " Slovo se ponavlja " + brojac);


