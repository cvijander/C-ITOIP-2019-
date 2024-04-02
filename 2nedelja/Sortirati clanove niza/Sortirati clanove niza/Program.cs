// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sortirati clanove niza ");

int[] niz = { 3, 2, 166, 77, 85, 99, 1, 5 };

// klasa Array koja radi sa nizovima 
// metodi Sort se prosledjuje ime niza 
Array.Sort(niz);
for (int i = 0; i < niz.Length; i++)
{
    Console.WriteLine(niz[i]);
}
