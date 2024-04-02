// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
{

    Console.WriteLine("Korisnik unosi brojeve u listu L");
    Console.WriteLine("sve dok se ne ispise jedan negativan broj ");
    Console.WriteLine("Program ispisuje proizvod brojeva ");

    int broj = int.Parse(Console.ReadLine());
    List<int> listaBrojeva = new List<int>();

    while (broj > 0)
    {
        listaBrojeva.Add(broj);

        broj = int.Parse(Console.ReadLine());

    }
    Console.WriteLine("Proizvod svih brojeva " + Proizvod(listaBrojeva));
}

 static int Proizvod(List<int> L)
{
    int pr = 1;
    foreach(int i in L)
    {
       pr *= i;
    }
    return pr;
}






