// See https://aka.ms/new-console-template for more information
Console.WriteLine("Deklarisanje niza na pocetku ");


int[] mojNiz = new int[6];
Console.WriteLine("Unesi vrednosti clanova niza ");
for (int i = 0; i < mojNiz.Length; i++)
{
    mojNiz[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Prikazi clanove niza ");

for(int i = 0;i < mojNiz.Length;i++)
{
    Console.Write(mojNiz[i]+" ");
}