// See https://aka.ms/new-console-template for more information
Console.WriteLine("Za uneta imena napisati ih u obliku Prvo Veliko slovo i ostala mala ");

Console.WriteLine("Koliko zelite da imate imena ");
int brojac = int.Parse(Console.ReadLine());

string[] imena = new string[brojac];

for (int i = 0; i < brojac; i++)
{
    imena[i] = Console.ReadLine();
}



Array.Sort(imena);
foreach (string name in imena)
{
    string okName = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
    Console.WriteLine(okName);
}
