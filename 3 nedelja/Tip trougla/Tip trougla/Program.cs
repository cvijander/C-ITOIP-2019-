// See https://aka.ms/new-console-template for more information
using Tip_trougla;

Console.WriteLine("Dodati metodu Tip() sa kojom se proverava da li je trougao pravugli, tupougli ili ostrougli ");


Trougao T = new Trougao();
Console.Write("a = ");
T.a_set(float.Parse(Console.ReadLine()));
Console.Write("b = ");
T.b_set(float.Parse(Console.ReadLine()));
Console.Write("c = ");
T.c_set(float.Parse(Console.ReadLine()));
T.PrikazStranica();
T.Obim();
T.Tip();