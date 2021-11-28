using System;
using System.Globalization;


namespace Simple_Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] product1, product2;
            double totalValue, productValue1, productValue2;

            product1 = Console.ReadLine().Split(' ');
            product2 = Console.ReadLine().Split(' ');

            productValue1 = int.Parse(product1[1]) * double.Parse(product1[2]);
            productValue2 = int.Parse(product2[1]) * double.Parse(product2[2]);
            totalValue = productValue1 + productValue2;

            Console.WriteLine($"VALOR A PAGAR: R$ {totalValue.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
