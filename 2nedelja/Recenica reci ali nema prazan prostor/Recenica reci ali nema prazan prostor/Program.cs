// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program ispisuje reci jednu ispod druge ali i koliko ih ima i ignorise vise razmaka ");

Console.WriteLine("Unesite recenicu ");
string recenica = Console.ReadLine();
string novaRecenica = "";
int brojac = 0;

for (int i = 0;i<recenica.Length;i++)
{
    if (recenica[i]==' ' && recenica[i-1] !=' ')
    {
        brojac++;
        novaRecenica += "\n";
    }
    else if (recenica[i] !=' ')
    {
        novaRecenica += recenica[i];
    }
}
Console.WriteLine("Nova recenica ");
Console.WriteLine(novaRecenica);
Console.WriteLine((brojac+1));
