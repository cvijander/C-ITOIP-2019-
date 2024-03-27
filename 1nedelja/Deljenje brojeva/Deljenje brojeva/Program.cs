// See https://aka.ms/new-console-template for more information
Console.WriteLine("Deljenje brojeva");
Console.WriteLine("Unesite prvi broj");
int broj1 = int.Parse(Console.ReadLine());
Console.WriteLine("Unesite drugi broj");
int broj2 = int.Parse(Console.ReadLine());
if(broj2 !=0 )
{
    double kolicnik = (double)broj1 / broj2;
    Console.WriteLine("Kolicnik brojeva je {0}",kolicnik);
}
else
{
    Console.WriteLine("Nije moguce deliti nulom");
}
