using System;

namespace Banknotes
{
    class Program
    {
        static void Main(string[] args)
        {
            int value, aux;
            int[] moneyBill = { 100, 50, 20, 10, 5, 2, 1};


            value = int.Parse(Console.ReadLine());
            Console.WriteLine(value);
            for(int i = 0; i < moneyBill.Length; i++)
            {
                aux = value / moneyBill[i];
                if(aux > 0)
                {
                    value -= aux * moneyBill[i];
                }
                Console.WriteLine($"{aux} nota(s) de R$ {moneyBill[i]},00");
            }

        }
    }
}
