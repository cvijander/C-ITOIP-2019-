// See https://aka.ms/new-console-template for more information
Console.WriteLine("Napisati program koji ispisuje pravougaonik sastavljen od znaka #");
Console.WriteLine("Velicine MxN gde brojeve M i N bira korisnik");
Console.WriteLine("A sa funkciojm CrtajRed()");
Console.WriteLine("B bez koriscenja funkcije");

Console.WriteLine("M= ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("N= ");
int n= int.Parse(Console.ReadLine());

/*
for(int i=0; i<m; i++)
{
    
    
        CrtajRed(n);
    
}

static void CrtajRed(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
*/

for(int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
        Console.Write("#");
    }
    Console.WriteLine();
}
