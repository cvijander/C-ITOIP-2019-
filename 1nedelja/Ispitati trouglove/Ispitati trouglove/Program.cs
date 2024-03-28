// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ispitati trogao da li je jednakostranican, jednokraki ili raznostranicni ");
Console.WriteLine("Jednakostranicni trougao ima sve tri stranice iste duzine");
Console.WriteLine("Jednakokraki trougao ima dve stranice iste duzine dok je treca ili manja ili veca od preostale dve");
Console.WriteLine("Raznostranicni, kao sto naziv kaze svaka stranica nije iste velicine kao prethodnodna");

Console.WriteLine("Unesite vrednost stranice a: ");
int stranicaA = int.Parse(Console.ReadLine());
Console.WriteLine("Unesite vrednost stranice b : ");
int stranicaB = int.Parse(Console.ReadLine());
Console.WriteLine("Unesite vrednosti stranice c: ");
int stranicaC = int.Parse(Console.ReadLine());  

if ((stranicaA == stranicaC ) && (stranicaA != stranicaB) && (stranicaB != stranicaC))
{
    Console.WriteLine("Trougao je jednokraki");
}
else if ((stranicaA == stranicaC ) && (stranicaA == stranicaB) && (stranicaB ==stranicaC))
{
    Console.WriteLine("Trougao je jednakostranicni");
}
else if((stranicaA !=stranicaB) && (stranicaA != stranicaC) && (stranicaB != stranicaC) )
{
    Console.WriteLine("Trougao je razlicitostranicni");
}

