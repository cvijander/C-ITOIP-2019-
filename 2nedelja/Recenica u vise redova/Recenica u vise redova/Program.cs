// See https://aka.ms/new-console-template for more information
Console.WriteLine("Napisati progrma koji za unetu recenicu ispisuje reci jednu ispod druge");
Console.WriteLine("Nakon toga ispisuje koliko je bilo reci");

Console.WriteLine("Unesite recenicu");
string recenica = Console.ReadLine();
string novaRecenica = "";
int brojRecenica = 0;

for (int i = 0; i< recenica.Length; i++)
{
    if (recenica[i] ==' ')
    {
        novaRecenica += "\n";
        brojRecenica++;
    }
    else
    {
        novaRecenica += recenica[i];
    }
}

Console.WriteLine("Ukupno ima ");
Console.WriteLine(novaRecenica);
Console.WriteLine("Brojac " + (brojRecenica+1));

