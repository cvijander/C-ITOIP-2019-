// See https://aka.ms/new-console-template for more information


Console.WriteLine("Program izracunava idealnu tezinu za zene !");

Console.WriteLine("Unesi visinu  u cm ");
double visina = double.Parse(Console.ReadLine());
Console.WriteLine("Idealna tezina je " + Izracunaj(172));
Console.WriteLine("Idelana tezina je " + Izracunaj(191)) ;
Console.WriteLine("Idelana tezina je " + Izracunaj(visina));




static double Izracunaj(double visina )
{
    double idealnaTezina = visina - 110;
    return idealnaTezina;
}

