// See https://aka.ms/new-console-template for more information
Console.WriteLine("Niz kola ");
string[] cars = new string[] { "Audi", "BMW", "Toyota", "Honda", "Lexus" };

Array.Sort(cars);
Array.Reverse(cars);
foreach (string car in cars)
{
    Console.WriteLine(car);
}
