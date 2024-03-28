// See https://aka.ms/new-console-template for more information
Console.WriteLine("Napisati program koji na osnovu unetog mesece, kao broja od 1-12 odredjuje u konizoli i stampa njegov broj dana ");
Console.WriteLine("Unesite broj izmedju 1 -12 ");
int month = int.Parse(Console.ReadLine());
int numberDaysInMonth = 0;



try
{
    if (month != 2)
    {
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                numberDaysInMonth = 31;
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                numberDaysInMonth = 30;
                break;

        }
        Console.WriteLine("Ima tacno " + numberDaysInMonth + " dana.");
    }
    else
    {
        Console.WriteLine("Uneti kalendarsku godinu");
        int year = int.Parse(Console.ReadLine());
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            numberDaysInMonth = 29;
            Console.WriteLine("Ima 366 dana, dakle februar ima " +numberDaysInMonth +" dana.");
            
        }
        else
        {
            numberDaysInMonth = 28;
            Console.WriteLine("Nije prestupan dakle 365 tj februar ima " +numberDaysInMonth+ " dana." );
        }
    }

    

}
catch (Exception)
{

    Console.WriteLine("Pogresan unos");
}


