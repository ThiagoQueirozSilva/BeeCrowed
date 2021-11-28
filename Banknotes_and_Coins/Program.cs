using System;
using System.Globalization;


namespace Banknotes_and_Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double value;
            int  aux;
            int[] moneyBills = { 100, 50, 20, 10, 5, 2 };
            double[] moneyCoins = { 1.00, 0.5, 0.25, 0.10, 0.05, 0.01 };

            value = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTAS:");
            for (int i = 0; i < moneyBills.Length; i++)
            {
                aux = (int)(value / moneyBills[i]);
                if (aux > 0)
                {
                    value -= aux * moneyBills[i];
                    value = Math.Round(value, 2);
                }
                Console.WriteLine($"{aux} nota(s) de R$ {moneyBills[i]}.00");
            }

            Console.WriteLine("MOEDAS:");
            for (int i = 0; i < moneyCoins.Length; i++)
            {
                aux = (int)(value / moneyCoins[i]);

                if (aux > 0)
                {
                    value -= aux * moneyCoins[i];
                    value = Math.Round(value, 2);
                }

                Console.WriteLine($"{aux} moeda(s) de R$ {moneyCoins[i].ToString("F2", CultureInfo.InvariantCulture)}");

            }

        }
    }
}
