// See https://aka.ms/new-console-template for more information
using trougao_manja_povrsina;

Console.WriteLine("Omoguciti korisniku da u programu iz prethodnog zadatka ");
Console.WriteLine("pronadje trougao koji ima najmanju povrsinu i prikaze stranice tog trougla");
Console.WriteLine("koristiti listu koja ima 5 trouglova");

List<TRougao> listaT = new  List<TRougao>();
int imin = 0;
float pmin = 0;

for (int j = 0; j < 5; j++)
{
    Console.WriteLine("Unesite stranice trougla ");
    string odgovor =Console.ReadLine();
    TRougao t = new TRougao(odgovor);
    listaT.Add(t);
    if(j==0)
    {
        pmin = t.Povrsina();

    }
    else if(t.Povrsina() <pmin)
    {
         pmin=t.Povrsina();
        imin = j;
    }
    Console.WriteLine("Povrsina je " + t.Povrsina());
}

Console.WriteLine("Najmanju povrsinu ima " +(imin+1) + ". trougao");
Console.WriteLine("stranice su mu a= " + listaT[imin].A_get() + " b= " + listaT[imin].B_get() + " c= " + listaT[imin].C_get());


