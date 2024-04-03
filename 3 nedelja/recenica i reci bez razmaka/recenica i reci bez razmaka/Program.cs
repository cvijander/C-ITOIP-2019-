// See https://aka.ms/new-console-template for more information
Console.WriteLine("Napisati progrma koji za unetu recenicu ispisuje reci jednu ipod druge");
Console.WriteLine("Nakon toga progrma ispisuje koliko je reci bilo u rececnici , visestruki razmaci se ignorisu");

Console.WriteLine("Unesite recenicu ");
string recenica = Console.ReadLine();
string novaRecenica = "";
int brojac = 0;

for (int i = 0;i<recenica.Length;i++)
{
    if (recenica[i] ==' ' && recenica[i - 1] != ' ')
    {
        novaRecenica += "\n";
        brojac++;
    }
    else if (recenica[i] !=' ')
    {
        novaRecenica += recenica[i];
    }      
    
}

Console.WriteLine(novaRecenica);
Console.WriteLine("Ukupan broj reci " + brojac);
