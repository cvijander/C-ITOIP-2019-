// See https://aka.ms/new-console-template for more information
using Trougao_obim;

Console.WriteLine("Omoguciti programu sa se u programu izaracun obim trougla sa stanicama 3,4,5!");
Console.WriteLine("Koristi se metode za sve tri stranice ");

Trougao T       =new Trougao();
T.a_set(3);
T.b_set(4);
T.c_set(5);
T.PrikazStranica();

float obim = T.a_get()+ T.b_get() + T.c_get();
Console.WriteLine("Obim trougla je " +obim);
