// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Unesite broj vec od 1");

int n = int.Parse(Console.ReadLine());

int maks=(int)Math.Sqrt(n);

bool dalije =false;



   for (int i = 2; i<= maks; i++)
{
    if(n % i ==0)
    {
        dalije = true;
        break;
    }

    string rezultat = "";
    if(dalije)
    {
        Console.WriteLine("Broj nije prost");
    }
    else
    {
        Console.WriteLine("Jeste prost ");
    }
}
