// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program proverava teskt izgovoren u telefonskom razgovoru i ispisuje !");
Console.WriteLine("broj izgovorenih reci (zavera , tajna, bomba)");

Console.WriteLine("Unesi teskt razgovora");
string razgovor =Console.ReadLine();

int broj = BrojKljucnihReci(razgovor);
Console.WriteLine("Broj izgovorrewnih reci " + broj);


static int BrojKljucnihReci(string razgovor)

{
    string[] kReci = { "zavera", "tajna", "bomba" };
    string[] sveReci = razgovor.Split(' ', ',', '.');
    int poklapanja = 0;
    foreach (string k in kReci)
    {
        foreach (string r in sveReci)
        {
            if (k == r) poklapanja++;
        }
    }
    return poklapanja;
}