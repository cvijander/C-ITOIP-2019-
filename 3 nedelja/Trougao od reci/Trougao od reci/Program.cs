// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program unosi receniocu i sastavlja trougao od reci tako sto svaki put izostavi prvu rec");

Console.WriteLine("Unesi recenicu");
string recenica = Console.ReadLine();

string[] reci = recenica.Split(' ');

for (int i = 0; i < reci.Length; i++)
{
    for (int j = i; j < reci.Length; j++)
    {
        Console.Write(reci[j]+" ");
    }
    Console.WriteLine();
}
