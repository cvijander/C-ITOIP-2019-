// See https://aka.ms/new-console-template for more information
Console.WriteLine("Korisnik unosi recenicu  i svi njeni karakteri se upisuju u listu L");
Console.WriteLine("Program ispisuje recenicu u originalu a zatim iz liste izbacue slova E,e");
Console.WriteLine("Na kraju se izbacuju svi preostalo karakteri iz liste");

Console.WriteLine("Unesi recenicu");
string recenica =Console.ReadLine();
Console.WriteLine(recenica);
List<char> listCharacter = new List<char>();
foreach(char letter in recenica)
{
    listCharacter.Add(letter);
}

while (listCharacter.Contains('e'))
{
    listCharacter.Remove('e');
}

while (listCharacter.Contains('E'))
{
    listCharacter.Remove('E');
}

foreach (char let in listCharacter)
{
    Console.WriteLine(let);
}
Console.WriteLine();

