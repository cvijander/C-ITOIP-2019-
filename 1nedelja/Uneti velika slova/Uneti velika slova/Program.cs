// See https://aka.ms/new-console-template for more information
Console.WriteLine("Za uneto ime program ispisuje sve slova kao VELIKA sa scrticama npr V-E-L-I-K-A");
Console.WriteLine("Unesite ime ");
string ime= Console.ReadLine();
for(int i =0; i<ime.Length; i++)
{
    char x = Char.ToUpper(ime[i]);

    if(i != ime.Length -1)
    {
        Console.Write(x+"-");
    }
    else
    {
        Console.WriteLine(x);
    }
}

