// See https://aka.ms/new-console-template for more information
Console.WriteLine("Simulacija e shopa ");
Console.WriteLine("Unosite majica, sorc, patike, torba");
char velicina;
int iznos = 0;

Console.WriteLine("Dodaj u korpu ");
string izaberi = Console.ReadLine();
switch(izaberi)
{
    case "majica":
        iznos += 2500;
        break;

    case "sorc":
        iznos += 3000;
        break;

    case "patike":
        iznos += 6000;
        break;

    case "torba":
        iznos += 4000;
        break;

    default:
        Console.WriteLine("Morate odabrati jednu od opcija majica, sorc, patike ili torba");
        break;

}

Console.WriteLine("Izaberite jednu od ponudjenih velicina");

