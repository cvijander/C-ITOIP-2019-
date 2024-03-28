// See https://aka.ms/new-console-template for more information
Console.WriteLine("Suma brojeva ");
Console.WriteLine("Ucitaj n");
int n = int.Parse(Console.ReadLine());
int suma = 0;

for(int i =0; i<= n; i++)
{
    Console.WriteLine("Trenutno i je " + i);
    suma = suma + (int)i;
    
    Console.WriteLine("Trenutna suma " + suma + " i ona je zbir postojece sume i " + i);
    
}
Console.WriteLine();
Console.WriteLine("Ukupna suma tj konacna ");
Console.WriteLine(suma);
