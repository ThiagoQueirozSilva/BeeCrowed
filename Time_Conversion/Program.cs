using System;

namespace Time_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int secondsInput, hours, minutes, seconds;

            secondsInput = int.Parse(Console.ReadLine());
            hours = secondsInput / 3600;
            secondsInput -= hours * 3600;
            minutes = secondsInput / 60;
            secondsInput -= minutes * 60;
            seconds = secondsInput;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
