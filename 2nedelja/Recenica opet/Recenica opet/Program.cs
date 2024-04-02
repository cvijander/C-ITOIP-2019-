// See https://aka.ms/new-console-template for more information
Console.WriteLine("Korisnik unosi recenicu a program na slucajan nacin bira redosled karaktera ");
Console.WriteLine("Ispisuje sve karaktere iz te recenice po tom redosledu");

Console.WriteLine("Unesite recenicu");
string recenica =Console.ReadLine();
Console.WriteLine(recenica);

List<char> listaKaraktera = new List<char>();
Random random = new Random();

foreach (char slovo in recenica)
{
    listaKaraktera.Add(slovo);
}

while(listaKaraktera.Count >0)
{
    int slucajno = random.Next(0, listaKaraktera.Count);
    Console.Write(listaKaraktera[slucajno]);
    listaKaraktera.RemoveAt(slucajno);
}
