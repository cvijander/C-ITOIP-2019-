// See https://aka.ms/new-console-template for more information
Console.WriteLine("Brojevi");
Console.WriteLine("Ucitaj n");
int n = int.Parse(Console.ReadLine());
int suma = 0;
int i =1;
while (i <= n )
{
    suma = suma + i;
    i++;
}
Console.WriteLine("Rezultat je {0} ", suma);


