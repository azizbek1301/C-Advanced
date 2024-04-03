
using System.Numerics;



//Console.Beep(10000, 5000);
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("Hello");

DateTime dateTime = new DateTime(2023, 07, 26);
Console.WriteLine(dateTime.DayOfYear);

DateTime afterTendayDateTime = dateTime.AddDays(48);
Console.WriteLine(afterTendayDateTime.DayOfYear);

Console.WriteLine("Hello world");
ConsoleKeyInfo c=Console.ReadKey();
Console.WriteLine(c.Key);

if(c.Key==ConsoleKey.Enter)
{

    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("Blue");
}


var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

foreach (var item in nums)
{
    Console.Write(item+1+" ");
}
