// See https://aka.ms/new-console-template for more information
Console.WriteLine("Suma elemenata niza ");
int[] niz = { 3, 2, 166, 77, 55, 85, 1, 5, 9 };

int suma = 0;
for (int i = 0; i < niz.Length; i++)
{
    suma += niz[i];
}

Console.WriteLine("Suma je " +suma);
