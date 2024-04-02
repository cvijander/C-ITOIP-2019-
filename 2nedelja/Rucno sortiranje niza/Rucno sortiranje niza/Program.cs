// See https://aka.ms/new-console-template for more information
Console.WriteLine("Rucno sortiranje niza !");

int[] niz = { 3, 2, 155, 88, 97, 15, 23, 64, 11, 5 };

// pretpostavljamo da je prvi clan niza tj na nultoj poziciji maksimalni i onda se prolazi kroz preostali niz i proveramo 
// da li je sledeci element veci / manji 

int max = niz[0];
int min = niz[0];

for (int i = 0; i < niz.Length; i++)
{
    if (niz[i] > max)
    {
        max = niz[i];
    }
    if (niz[i] < min)
    {
        min = niz[i];
    }
}

Console.WriteLine(max);
Console.WriteLine(min);
