// See https://aka.ms/new-console-template for more information
Console.WriteLine("Napisati program koji za unetu recenicu ispisuje reci ");

Console.WriteLine("Unesite recenicu");
string recenica = Console.ReadLine();
string novaRecenica = "";
for (int i = 0; i< recenica.Length; i++)
{
    if (recenica[i]==' ')
    {
        novaRecenica += '\n';
    }
    else
    {
        novaRecenica+= recenica[i];
    }
    
}
Console.WriteLine(novaRecenica);
