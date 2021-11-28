using System;
using System.Globalization;


namespace Salary_With_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double fixedSalary, soldInMounth, finalSalary;

            name = Console.ReadLine();
            fixedSalary = double.Parse(Console.ReadLine().Replace('.', ','));
            soldInMounth = double.Parse(Console.ReadLine().Replace('.', ','));

            finalSalary = (soldInMounth * 0.15) + fixedSalary;
            Console.WriteLine("TOTAL =  R$ " + finalSalary.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
