// See https://aka.ms/new-console-template for more information
Console.WriteLine("Koriusnik unosi prirodni broj a program preko liste ispisuje njegove delioce");

Console.WriteLine("Unesi prirodni broj ");
int broj = int.Parse(Console.ReadLine());
List<int> listaBrojeva = new List<int>();
listaBrojeva.Add(1);

for (int i = 2;i< broj/2; i++)
{
    if(broj % i ==0)
    {
        listaBrojeva.Add(i);
    }
}

if(broj>1)
{
    listaBrojeva.Add(broj);
}

foreach (int  item in listaBrojeva)
{
    Console.WriteLine(item +" ") ;
}


