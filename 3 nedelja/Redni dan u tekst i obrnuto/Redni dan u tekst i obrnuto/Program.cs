// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program prevodi redni broj dana u nedelji u tekstualni obrnuto");
Console.WriteLine("Unesi smer (1 - po rednom broju ) , 2 - po tekstu ");
string odgovoro= Console.ReadLine();

string[] dani = { "Ponedeljak", "Utorak", "Sreda", "Cetvrtak", "Pewtak", "Subota", "Nedelja" };

if(odgovoro =="1")
{
    Console.Write("Unesi redni broj: ");
    int broj = int.Parse(Console.ReadLine());

    if(broj < 0 || broj >6 )
    {
        Console.WriteLine("Greska");
    }
    else
    {
        Console.WriteLine("Dan " + dani[broj]);
    }
}

else if (odgovoro =="2")
{
    Console.Write("Unesi dan: ");
    string dan = Console.ReadLine();
    Console.WriteLine("Redni broj "+ RedniBroj(dan));
}

static string RedniBroj(string dan)
{
    string odgovor = "Greska";
    string[] dani = { "Ponedeljak", "Utorak", "Sreda", "Cetvrtak", "Pewtak", "Subota", "Nedelja" };

    for (int i = 0; i < 7; i++)
    {
        if(dan.ToUpper() == dani[i].ToUpper())
        {
            odgovor = (i +1) + ".";
        }


    }
    return odgovor;
}