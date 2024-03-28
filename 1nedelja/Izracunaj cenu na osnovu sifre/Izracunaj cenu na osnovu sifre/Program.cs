// See https://aka.ms/new-console-template for more information


char c='n';
do
{
    try
    {
        Console.WriteLine("Molim Vas unesite cenu");
        double cena = double.Parse(Console.ReadLine());
        Console.WriteLine("Unesite cifru 1-pravno lice ili  2-fizicko lice");
        int vrednost = int.Parse(Console.ReadLine());
        if (vrednost == 1)
        {
            double pravnaCena = cena * 1.2;
            Console.WriteLine("Posto je uneta vrednost pravno lice , vasa nova cena je " + pravnaCena);
        }
        else
        {
            double fizickaCena = cena * 1.08;
            Console.WriteLine("Poste je u pitanju fizicko lice, Vasa nova cena je " + fizickaCena);
        }

        Console.WriteLine("Da li zelite da unesete ponovo ? (Y /N )");
        c = char.Parse(Console.ReadLine());
       
    }
    catch (Exception e)
    {

        Console.WriteLine("Niste uneli u adekvatnom formatu");
    }
} while (Char.ToUpper(c) == 'Y');




