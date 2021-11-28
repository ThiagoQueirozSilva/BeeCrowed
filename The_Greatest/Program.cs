using System;

namespace The_Greatest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers;
            int a, b, c, best;

            numbers = Console.ReadLine().Split(' ');
            a = int.Parse(numbers[0]);
            b = int.Parse(numbers[1]);
            c = int.Parse(numbers[2]);

            best = ReturnBest(a, b);
            best = ReturnBest(best, c);
            Console.WriteLine($"{best} eh o maior");


        }

        static int ReturnBest(int a, int b)
        {
            return (a + b + Math.Abs(a - b)) / 2;
        }
    }
}
