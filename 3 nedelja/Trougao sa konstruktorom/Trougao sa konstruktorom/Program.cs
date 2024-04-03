// See https://aka.ms/new-console-template for more information
using Trougao_sa_konstruktorom;

Console.WriteLine("Napisati klasu trougao koja ima konstruktor metode za obim i povrsinu ");
Console.WriteLine("napisati progrma koji unosi stranice trougla u jednom redu ");
Console.WriteLine("i u sledeca dva reda teksta ispisuje povrsinu i obim");

Console.WriteLine("Unesi stranice ");
string odgovor = Console.ReadLine();
string[] niz = odgovor.Split(' ');
float a = float.Parse(niz[0]);
float b = float.Parse(niz[1]);
float c = float.Parse(niz[2]);

Trougao t = new Trougao(a,b,c);
Console.WriteLine("Obim " +t.Obim());
Console.WriteLine("Povrsina " +t.Povrsina());