// See https://aka.ms/new-console-template for more information
Console.WriteLine("Korisnik unosi recenicu a program na slucajan nacin ");
Console.WriteLine("Bira redoslek karktera i onda ispusuje sve karaktere po to redosledu");

Console.WriteLine("Unesite recenicu ");
string recenica = Console.ReadLine();
Console.WriteLine(recenica);

Random random = new Random();

List<char> listKaraktera = new List<char>();
int polozaj = random.Next(0, listKaraktera.Count);

foreach (char c in recenica)
{
    listKaraktera.Add(c);
}

while (listKaraktera.Count>0)
{
    char c = listKaraktera[polozaj];
    Console.Write(c);
    listKaraktera.RemoveAt(polozaj);
}

Console.WriteLine();

