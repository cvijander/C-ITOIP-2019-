// See https://aka.ms/new-console-template for more information


Console.WriteLine("Korisnik unosi realne brojeve dok se ne unese negativan broj ");
float broj = float.Parse(Console.ReadLine());
float zbir = 0;
while (broj > 0 )
{
    zbir += broj;
    broj = float.Parse( Console.ReadLine());
}

Console.WriteLine("Zbir  = " + zbir);
