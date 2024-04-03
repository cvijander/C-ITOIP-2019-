// See https://aka.ms/new-console-template for more information
Console.WriteLine("Napisati program koji za unetu recenicu ispisuje piramidu unetih karaktera");
Console.WriteLine("Aklo se unese petak, dobija se etak tak ak k");

Console.WriteLine("Unesite recenicu ");
string recenica = Console.ReadLine();

for (int i = 0;i< recenica.Length;i++)
{
    for (int j = i;j< recenica.Length;j++)
    {
        Console.Write(recenica[j]);
    }
    Console.WriteLine();
}
