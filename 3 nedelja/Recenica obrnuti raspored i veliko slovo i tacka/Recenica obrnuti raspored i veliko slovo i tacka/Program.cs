// See https://aka.ms/new-console-template for more information
Console.WriteLine("Procitati recenicu i sve reci i ispisati u suprotnom redoledeu");
Console.WriteLine("Pri tome voditi racuna da prvo slovo u recnici bude veliko ");
Console.WriteLine(" a da na kraju stoji tacka");

Console.WriteLine("Unesite recenisu");
string recenica = Console.ReadLine();

if (recenica[recenica.Length-1] =='.')  // ako postoji tacka da je obrisemo
{
    recenica=recenica.Substring(0,recenica.Length-1);
}

string[] reci = recenica.Split(' ');

// prvo slovo poslednje reci treba da bude veliko
Console.Write(Char.ToUpper(reci[reci.Length - 1][0]));

// ostatak od poslednje reci 
string ost = reci[reci.Length - 1].Substring(1);
Console.Write(ost);

for (int i = reci.Length-2; i>=0; i--) //sve osim reci koja ce biti prva {
{
    Console.Write(" " + reci[i]);
}
Console.WriteLine('.');
