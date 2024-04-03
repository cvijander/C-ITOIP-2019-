// See https://aka.ms/new-console-template for more information
using _5_trouglova;

Console.WriteLine("Napisati program korz koji se unosi pet trouglova ");
Console.WriteLine("Program ispisuje trougao koji ima najvecu povrsinu");

float max = 0;
int indexMax = 1;

for (int j = 1;j<6;j++)
{
    Console.WriteLine("Unesite stranice " + j +". trougla");
    string odgovor = Console.ReadLine();
    string[] niz = odgovor.Split(' ');

    float a = float.Parse(niz[0]);
    float b = float.Parse(niz[1]);
    float c = float.Parse(niz[2]);

    Trougao t = new Trougao(a,b,c);
    float trenutnaPovrsina = t.Povrsina();
    if(trenutnaPovrsina > max)
    {
        max = trenutnaPovrsina;
        indexMax = j;
    }

}
Console.WriteLine("Najvecu povrsinu ima " + indexMax + ". trougao" );
