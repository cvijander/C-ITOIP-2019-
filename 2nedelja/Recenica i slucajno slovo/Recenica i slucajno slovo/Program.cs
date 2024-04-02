// See https://aka.ms/new-console-template for more information
Console.WriteLine("Korisink unosi recenicu a program na slucajan nacin ");
Console.WriteLine("Ispisuje jedan karakter iz te recenice ");

Console.WriteLine("Unesite recenicu ");
string recenica = Console.ReadLine(); 


Console.WriteLine(recenica);

 Random random = new Random();
int index = random.Next(0,recenica.Length);
Console.WriteLine("Slucajni karakter " + recenica[index] + " dok je slucajni karakter " + index);
