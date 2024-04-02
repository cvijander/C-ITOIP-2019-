// See https://aka.ms/new-console-template for more information
Console.WriteLine("Korisnik unosi dve recenice ");
Console.WriteLine("Program ispisuje karaktere prve koje nema u drugopoj");

Console.WriteLine("Unesite prvu recenicu ");
string recenica1 =Console.ReadLine();
Console.WriteLine("Unesite drugu recenicu");
string recenica2= Console.ReadLine();

List<char> lista1 =new List<char>();
List<char> lista2 =new List<char>();
List<char> lista3 =new List<char>();

foreach (char it1 in recenica1)
{
    lista1.Add(it1);

}

foreach (char it2 in recenica2)
{
    lista2.Add(it2);
}

foreach (char c in lista1)
{
    if(!lista2.Contains(c) && !lista3.Contains(c))
    {
        lista3.Add(c);
    }
}

foreach(char a in lista3)
{
    Console.WriteLine(a +" ");
}
    
