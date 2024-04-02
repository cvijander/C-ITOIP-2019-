// See https://aka.ms/new-console-template for more information
Console.WriteLine("Korisnik upisuje recenicu a program izbacuje tri slucajna karaktera!");

Console.WriteLine("Unesite recenicu");
string recenica = Console.ReadLine();

List<char> lista = new List<char>();
Random r = new Random();

for (int i = 0;i<recenica.Length;i++)
{
    lista.Add(recenica[i]);
}

Console.WriteLine("Tri karaktera");
for (int i = 0; i < 3; i++)
{
    int poz = r.Next(0, lista.Count);
    //lista.RemoveAt(poz);
    // izbacio samo 3 slucajna mesta 

    char k = lista[poz]; // dobijam vrednost karaktera 
    Console.WriteLine(k+ " ");
    while(lista.Contains(k))
    {
        lista.Remove(k); //ovde uklanja slovo a ne poziciju 
    }

}
Console.WriteLine("Prikaz");
foreach (char c in lista)
{
    Console.WriteLine(c + " " );
}
