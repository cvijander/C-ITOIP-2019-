// See https://aka.ms/new-console-template for more information
Console.WriteLine("Za unetu recenicu prikazuje reci i brojac");

Console.WriteLine("Unesite recenicu ");
string recenica = Console.ReadLine();

string novaRecenica = "";
int brojac = 0;

for (int i = 0; i < recenica.Length; i++)
{
    if (recenica[i] == ' ')
    {
        novaRecenica += "\n";
        brojac++;
    }
    else
    {
        novaRecenica+= recenica[i];
    }
}
Console.WriteLine(novaRecenica  + " brojac  " + (brojac+1));
