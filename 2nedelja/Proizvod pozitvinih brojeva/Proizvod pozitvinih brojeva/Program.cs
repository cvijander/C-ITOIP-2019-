// See https://aka.ms/new-console-template for more information
Console.WriteLine("Korisnik unosi pozitivne realne brojeve ");
Console.WriteLine("Sve dok ne unese jedan negativan ");
Console.WriteLine("Program ispisuje proizvod pozitvinih brojeva");

Console.WriteLine("Unesite brojeve ");
float broj = float.Parse(Console.ReadLine());
float sum=1;

while (broj > 0)
{
    sum *= broj;

    broj = float.Parse(Console.ReadLine());

}

Console.WriteLine("Sum je " + sum);
