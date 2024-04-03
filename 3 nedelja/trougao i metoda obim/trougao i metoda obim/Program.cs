// See https://aka.ms/new-console-template for more information
using trougao_i_metoda_obim;

Console.WriteLine("Dodati metodu Obim() koja ispisuje vrednost obima  ili gresku ako trougao nije ispravan ");

Trougao t = new Trougao();
Console.WriteLine("a= ");
t.a_set(float.Parse(Console.ReadLine()));
Console.WriteLine("b= ");
t.b_set(float.Parse(Console.ReadLine()));
Console.WriteLine("c= ");
t.c_set(float.Parse(Console.ReadLine()));
t.PrikazStranica();
t.Obim();
