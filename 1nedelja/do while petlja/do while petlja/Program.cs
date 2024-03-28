// See https://aka.ms/new-console-template for more information
Console.WriteLine("Do while petlja");

int ponovo = 0;
do
{
    Console.WriteLine("Unesite prvi broj");
    int prvi = int.Parse(Console.ReadLine());
    Console.WriteLine("Unesite drugi broj ");
    int drugi = int.Parse(Console.ReadLine());

    Console.WriteLine("{0} + {1} = {2}", prvi, drugi, prvi + drugi);
    Console.WriteLine("Da li zelite novo racunjanje? 1-DA , 0 -NE ");
    ponovo = int.Parse(Console.ReadLine());
} while (ponovo ==1);

