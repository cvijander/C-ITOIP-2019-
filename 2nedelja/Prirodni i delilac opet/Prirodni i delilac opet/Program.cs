// See https://aka.ms/new-console-template for more information
Console.WriteLine("Korisnik unosi prirodni broj a program preko liste ispisuje sve njegove delioce");

Console.WriteLine("Unesi prirodni broj ");
int broj = int.Parse(Console.ReadLine());
List<int> list = new List<int>();

list.Add(1);

for (int i = 2;i<= broj/2; i++)
{
    if(broj % i==0)
    {
        list.Add(i);
    }
}
if (broj>1)
{
    list.Add(broj);
}

Console.WriteLine("Prikaz");
foreach (int i in list)
{
    Console.WriteLine(i);
}
