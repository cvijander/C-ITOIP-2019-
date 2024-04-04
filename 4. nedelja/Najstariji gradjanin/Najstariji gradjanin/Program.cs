// See https://aka.ms/new-console-template for more information
using Najstariji_gradjanin;

Console.WriteLine("Hello, World!");


Console.WriteLine("n= ");
int n = int.Parse(Console.ReadLine());
List<Gradjanin> lista = new List<Gradjanin>();

int max = 0;
int imax = 0;

for (int j = 0; j < n; j++)
{
    Console.WriteLine("unesite " + (j+1)+ " gradjanina " );
    string odg = Console.ReadLine();
    string[] niz = odg.Split(' ');
    Gradjanin g = new Gradjanin(niz[0], niz[1], niz[2]);
    lista.Add(g);

    if(int.Parse(g.MinutiStarosti()) > max)
    {
        max = int.Parse(g.MinutiStarosti());
        imax = j;
    }
}

Gradjanin najstariji = lista[imax];
Console.WriteLine("Odgovor");
Console.WriteLine(najstariji.jmbg_get() + " " + najstariji.Ime_get()+ " " + najstariji.prezime_get());