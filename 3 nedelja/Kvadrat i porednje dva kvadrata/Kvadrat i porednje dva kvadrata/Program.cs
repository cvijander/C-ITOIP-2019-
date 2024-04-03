// See https://aka.ms/new-console-template for more information
using Kvadrat_i_porednje_dva_kvadrata;

Console.WriteLine("Koristeci klasu kvadrat i njene metode napisati program koji korisnik unosi za stranice dva kvadrata");
Console.WriteLine("Progrma ispisuje razliku njihovih obima i razliku njihovih povrsina");
Console.WriteLine("obavezno se od veceg obim oduzima manji i takodje i kod povrsine");

Kvadrat k1 = new    Kvadrat();
Kvadrat k2 = new Kvadrat();
Console.WriteLine("Stranica prvog kvadrata");
k1.a_set(float.Parse(Console.ReadLine()));
Console.WriteLine("Stranica drugo kvadrata");
k2.a_set(float.Parse(Console.ReadLine()));

Console.WriteLine("Razlika obima " +Math.Abs(k1.Obim() - k2.Obim()));
Console.WriteLine("Razlika povrsina" + Math.Abs(k1.Povrsina() - k2.Povrsina()));
