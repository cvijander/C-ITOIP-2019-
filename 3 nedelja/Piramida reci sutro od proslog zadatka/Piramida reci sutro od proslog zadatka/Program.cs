// See https://aka.ms/new-console-template for more information
Console.WriteLine("Piramida reci ");
Console.WriteLine("Unesite recenicu ");

string recenica = Console.ReadLine();
for (int i = 0;i<recenica.Length;i++)
{
    for (int j = 0;j< recenica.Length-i;j++)
    {
        Console.Write(recenica[j]);
    }
    Console.WriteLine();
}
