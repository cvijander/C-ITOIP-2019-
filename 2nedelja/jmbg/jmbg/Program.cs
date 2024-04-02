// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iz jmbg izvuci dan, mesec, godinu rodjenja i predvideti kad godina pocinje sa 19 i 20!");

Console.WriteLine("Unesite jmbg");
string jmbg = Console.ReadLine();

string dan = jmbg.Substring(0, 2);
string mesec = jmbg.Substring(2, 2);
string godina = jmbg.Substring(4, 3);

int godinaToInt = int.Parse(godina);

if(godinaToInt < 1000)
{
    godinaToInt += 1000;
}
else
{
    godinaToInt += 2000;
}

Console.WriteLine("Dan rodjenja " + dan );
Console.WriteLine("Mesec " + mesec);
Console.WriteLine("Godina " + godinaToInt);
