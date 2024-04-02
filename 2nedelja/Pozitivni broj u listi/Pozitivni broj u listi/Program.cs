// See https://aka.ms/new-console-template for more information
Console.WriteLine("Korisnik unosli u listu L! pozitivne relane brojeve");
Console.WriteLine("Sve dok ne unese jedan negativan");
Console.WriteLine("Program ispisuje zbir svih pozitinih brojeva , prosek i koliko ih ima");

Console.WriteLine("Unesite broj ");
float broj = float.Parse(Console.ReadLine());
List<float> lista = new List<float>();

while( broj >0)
{
    lista.Add(broj);
    broj = float.Parse(Console.ReadLine());
}

Console.WriteLine("Ukupno ih ima " + lista.Count);
Console.WriteLine("Zbir " + lista.Sum());
Console.WriteLine("Prosek " + lista.Average());
