// See https://aka.ms/new-console-template for more information
using Trougao_ispravnost;

Console.WriteLine("Dodati metodu ProveraIspravnosti kroz koju se proveri nejednakost trougal");
Console.WriteLine("a<b+c , b < a+c , c< a+b");
Console.WriteLine("Korisnik aplikacije sam uosi vrednost stranica");

Trougao t = new Trougao();
Console.WriteLine("a= ");
t.a_set(float.Parse(Console.ReadLine()));
Console.WriteLine("b= ");
t.b_set(float.Parse(Console.ReadLine()));
Console.WriteLine("c= ");
t.c_set(float.Parse(Console.ReadLine()));

t.PrikaziStranice();
float obim = t.a_get()+ t.b_get() + t.c_get();
Console.WriteLine("Obim je " + obim);
t.ProveraIspravnosti();
