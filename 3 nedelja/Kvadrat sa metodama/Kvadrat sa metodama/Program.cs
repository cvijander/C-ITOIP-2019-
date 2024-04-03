// See https://aka.ms/new-console-template for more information
using Kvadrat_sa_metodama;

Console.WriteLine("Napisati klasu kvadrat sa atributom a  stranica kvadrata ");
Console.WriteLine("sa get iset metodom i sa metodama Obim() i Povrsina() koje vracaju relana broj ");
Console.WriteLine("Napisati progrma koji testira ovu klasu");

Kvadrat k = new Kvadrat();
Console.WriteLine("a= ");
k.a_set(float.Parse(Console.ReadLine()));

Console.WriteLine("Obim = " + k.Obim());
Console.WriteLine("Povrsina = " +k.Povrsina());


