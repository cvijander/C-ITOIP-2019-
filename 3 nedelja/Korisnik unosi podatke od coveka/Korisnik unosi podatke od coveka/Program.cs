// See https://aka.ms/new-console-template for more information
using Korisnik_unosi_podatke_od_coveka;

Console.WriteLine("Omoguciti korisniku da kroz klasu Covek moe da unese imena i prezimena ");
    Console.WriteLine(" za tri razlicita coveka ");
Console.WriteLine("U klasi obezberditi poruku da se desila greska ako je ime duze od 25 a prezime od 35 karaktera");



 
Covek a = new Covek ();
Covek b= new Covek ();
Covek c     = new Covek ();

Console.WriteLine("Ime prve osobe ");
a.Ime_set(Console.ReadLine());
Console.WriteLine("Ime druge osobe ");
b.Ime_set(Console.ReadLine());
Console.WriteLine("Ime trece osobe ");
c.Ime_set(Console.ReadLine());

Console.WriteLine("Prezime prve soboe");
a.Prezime_set(Console.ReadLine());
Console.WriteLine("Prezime druge osobe");
b.Prezime_set(Console.ReadLine());
Console.WriteLine("Prezime trece osobe");
c.Prezime_set(Console.ReadLine());

a.PozdraviSvet();
b.PozdraviSvet();
c.PozdraviSvet();
