// See https://aka.ms/new-console-template for more information
Console.WriteLine("Brise prvo slovo iz reci ");

Console.WriteLine("Unesite rec");
string rec = Console.ReadLine();

for (int i = 0;i<  rec.Length;i++)
{
    for (int j = i;j< rec.Length;j++)
    {
        Console.Write(rec[j]);
    }
    Console.WriteLine();
}
