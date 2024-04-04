// See https://aka.ms/new-console-template for more information
using trougao_sa_atributima;

Console.WriteLine("Napisati klasu trougao sa stranicama kao atribvutima, sa konstrutkorom koji moze da iz jednog tekta procita sve tri stranice ");
Console.WriteLine("i sa metodama za obim i povrsinu .Omoguciti korisniku da u Listu unuese 10 trouglova");
Console.WriteLine("Program ispisuje njihov ukupan obim i njihovu povrsinu ");

List<Trougao> listaTrouglova= new List<Trougao>();
for(int i = 0;i<10;i++)
{
    Console.WriteLine("Unesite stranice trougla");
    string odgovor = Console.ReadLine();
    Trougao t = new Trougao(odgovor);
    listaTrouglova.Add(t);
}

float ukPovrsina = 0;
float ukObim = 0;

foreach (Trougao trou in listaTrouglova)
{
    ukPovrsina += trou.Povrsina();
    ukObim += trou.Obim();
}
Console.WriteLine("Ukupna povrsina " +ukPovrsina);
Console.WriteLine("Ukupan obim " +ukObim);
