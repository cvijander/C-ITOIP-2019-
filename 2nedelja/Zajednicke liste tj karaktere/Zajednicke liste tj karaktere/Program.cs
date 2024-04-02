// See https://aka.ms/new-console-template for more information
Console.WriteLine("Korisnik unosi dve recenice a program ispisuje zajednicka karaktere");

Console.WriteLine("Unesite prvu recenicu ");
string recenica1 = Console.ReadLine();
Console.WriteLine("Unesite drugu recenicu");
string recenica2 =Console.ReadLine();

List<char> lista1 = new List<char>();
List<char> lista2 = new List<char>();
List<char> lista3 = new List<char>();

foreach (char i1 in recenica1)
{
    lista1.Add(i1);
}

foreach (char  i2 in recenica2)
{
    lista2.Add(i2);
}

Console.WriteLine("Zajednicki karakteri");

foreach (char caracter in lista1)
{
    if(lista2.Contains(caracter)&& (!lista3.Contains(caracter)))
    {
        Console.WriteLine(caracter + " ");
        lista3.Add(caracter);
    }

}