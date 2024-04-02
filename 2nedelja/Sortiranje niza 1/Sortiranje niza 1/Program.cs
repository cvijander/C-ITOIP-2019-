// See https://aka.ms/new-console-template for more information
Console.WriteLine("Sortiranje niza foreach");

int[] numbers = { 4, 3, 8, 12, 22, 66, 98, 41, 21, 32 };
Array.Sort(numbers);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}
