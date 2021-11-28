using System;

namespace Age_In_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysInput, years, months, days;

            daysInput = int.Parse(Console.ReadLine());
            years = daysInput / 365;
            daysInput -= years * 365;
            months = daysInput / 30;
            daysInput -= months * 30;
            days = daysInput;

            Console.WriteLine($"{years} ano(s)");
            Console.WriteLine($"{months} mes(es)");
            Console.WriteLine($"{days} dia(s)");
        }
    }
}
