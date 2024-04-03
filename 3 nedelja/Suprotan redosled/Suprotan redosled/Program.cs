// See https://aka.ms/new-console-template for more information
Console.WriteLine("Napisati recenicu i sve reci ispisati u suprotnom redolsedu !");

Console.WriteLine("Unesite recenicu");
string recenica = Console.ReadLine();

string[] reci = recenica.Split(' ');
for (int i = reci.Length-1; i >= 0; i--)
{
    Console.Write(reci[i]+" ");
}
Console.WriteLine();
