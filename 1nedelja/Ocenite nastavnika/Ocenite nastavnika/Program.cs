// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ocenite svog nastavnika ocenom od 1 -10 ");
Console.WriteLine("Ocena od 1-3 znaci da je nastavnik 'Jako los'");
Console.WriteLine("Ocena 4 do 5 da je nastavnik 'Prosecan'");
Console.WriteLine("Ocena od 6-9 da je 'Odlican'");
Console.WriteLine("Ocena 10 da je 'Izuzetan'");
Console.WriteLine("******************\n");


try
{
    Console.WriteLine("Unesite osnovnu visinu plate profesora: ");
    double paycheck = double.Parse(Console.ReadLine());
    Console.WriteLine("Unesite ocenu od 1- 10");
    int score = int.Parse(Console.ReadLine());

    if (score < 10 && score > 1)
    {



        switch (score)
        {
            case 1:
            case 2:
            case 3:
                paycheck = paycheck * .85;
                Console.WriteLine("Jako los i sada ima platu " + paycheck);
                break;

            case 4:
                paycheck = paycheck * 1.04;
                Console.WriteLine("Prosecan nastavnik i sada ima platu " + paycheck);
                break;

            case 5:
                paycheck = paycheck * 1.05;
                Console.WriteLine("Prosecan nastavnik i sada ima platu " + paycheck);
                break;


            case 6:
                paycheck = paycheck * 1.06;
                Console.WriteLine("Odlican nastavnik i sada ima platu " + paycheck);
                break;


            case 7:
                paycheck = paycheck * 1.07;
                Console.WriteLine("Odlican nastavnik i sada ima platu " + paycheck);
                break;

            case 8:
                paycheck = paycheck * 1.08;
                Console.WriteLine("Odlican nastavnik i sada ima platu " + paycheck);
                break;
            case 9:
                paycheck = paycheck * 1.09;
                Console.WriteLine("Odlican nastavnik i sada ima platu " + paycheck);
                break;


            case 10:
                paycheck = paycheck * 1.15;
                Console.WriteLine("Izuzetan  i sada ima platu " + paycheck);
                break;
        }
    }
    else
    {
        Console.WriteLine("Pogresna ocena je uneta ,trebalo je od 1-10.");
    }
}
catch (Exception)
{

    Console.WriteLine("Greska prilikom unosa");
}



