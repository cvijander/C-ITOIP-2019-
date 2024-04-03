// See https://aka.ms/new-console-template for more information


using System.Collections;

Console.WriteLine("Program nudi korisniku da unese 5 kljucnih reci ");
Console.WriteLine("Progrma pamti i nakon toga ponavlja sve reci");

ArrayList x = new ArrayList();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Unesi " + (i+1) +" kljucnu rec: ");
    string rec = Console.ReadLine();
    x.Add(rec);
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine((i+1) + " kljucna rec " + x[i]);
}
