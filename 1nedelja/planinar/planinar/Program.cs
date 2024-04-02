// See https://aka.ms/new-console-template for more information
Console.WriteLine("Planinar krece sa nadmorske velicine N i svaki dan se popne 250 metra");
Console.WriteLine("Svakog drugog danas duva jak veta,Tada uspe da se popne 150 metara ");
Console.WriteLine("Napisati program koji racuna visinu planiniskog vrha, ako se zna da se planinar popeo nakon 4 dana");
Console.WriteLine("Ako se zna da je prvog dana bilo lepo vreme");

int pocetnaVrednost = 0;
int neparanDan = 250;
int paranDan = 150;
int dan = 0;

for (int i = 1; i < 5; i++)
{
    if(i %2 ==0)
    {
        pocetnaVrednost += paranDan;
        dan++;
    }
    else if(i %2 ==1)
    {
        pocetnaVrednost += neparanDan;
        dan++;
    }
}

Console.WriteLine("Planinar je presao " + pocetnaVrednost);
Console.WriteLine("Za ukupnp dana " +dan);
