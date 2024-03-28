// See https://aka.ms/new-console-template for more information
Console.WriteLine("Unesite dan u nedelji vrednosti broja od 1-7 ");

char c='n';
do
{

    try
    {
	    int dan = int.Parse(Console.ReadLine());
	    if (dan ==6 || dan == 7)
	    {
            Console.WriteLine("Super vikend je ");
        }
        else if(dan < 6 && dan > 0)
        {
            Console.WriteLine("Radni dan. ");
        }
         else {
            Console.WriteLine("Neispravan dan");
        }
            Console.WriteLine("Da li zelite jos neki dan   ?  Y /N");
            c=char.Parse(Console.ReadLine());
        }
    catch (Exception)
    {

        Console.WriteLine("Greska prilikom unosa");
    }

} while (Char.ToUpper(c) =='Y');
