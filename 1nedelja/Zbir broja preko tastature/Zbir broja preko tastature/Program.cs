// See https://aka.ms/new-console-template for more information
Console.WriteLine("Zbir dva broja preko tastature");
Console.WriteLine("Unesite prvi broj:");
int broj1 = int.Parse(Console.ReadLine());
Console.WriteLine("Unesite drugi broj");
int broj2 = int.Parse(Console.ReadLine());
int zbir = broj1 + broj2;
int razlika = broj1 - broj2;
double kolicnik = (broj1 + 0.0) / broj2;
Console.WriteLine("Zbir brojeva je: {0} , a razlika je {1}, dok je kolicinik {2}", zbir, razlika, kolicnik);


