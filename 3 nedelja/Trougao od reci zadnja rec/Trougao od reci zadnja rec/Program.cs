// See https://aka.ms/new-console-template for more information
Console.WriteLine("Progrma unosi recenicu i sastavlja trougao od reci");
Console.WriteLine("tako sto svaki put izostavi poslednju rec");

Console.Write("Unesi recenicu ");
string recenica= Console.ReadLine();

string[] reci = recenica.Split(' ');

for(int i=0;i<reci.Length;i++)
{
    for(int j = 0; j < reci.Length-i;j++)
    {
        Console.Write(reci[j]+" ");
    }
    Console.WriteLine();
}
