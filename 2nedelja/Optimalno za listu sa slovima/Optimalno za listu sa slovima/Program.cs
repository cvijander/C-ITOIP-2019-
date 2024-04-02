// See https://aka.ms/new-console-template for more information
Console.WriteLine("Korisnik unosi recenicu koja se zatim ispisuje ");
Console.WriteLine("Nakon toga se izbacuju slova E i e iz liste i sve se ispise");

Console.WriteLine("Unesite recenicu ");
string recenica = Console.ReadLine();

Console.WriteLine(recenica);
List<char> listCharacter = new List<char>();
foreach (char i in recenica)
{
    if(i != 'e' && i !='E')
      listCharacter.Add(i);
}

Console.WriteLine("Prikazivanje ");
foreach (char letter in listCharacter)
{
    Console.Write(letter);
}
Console.WriteLine();


