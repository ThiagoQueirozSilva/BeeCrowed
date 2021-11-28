using System;
using System.Collections.Generic;

namespace Even_and_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,number;
            List<int> listOfEven = new List<int>();
            List<int> listOfOdd = new List<int>();

            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    listOfEven.Add(number);
                }
                else
                {
                    listOfOdd.Add(number);
                }

            }
            listOfEven.Sort();
            listOfOdd.Sort((x, y) => y.CompareTo(x));

            foreach(int num in listOfEven)
            {
                Console.WriteLine(num);
            }
            foreach(int num in listOfOdd)
            {
                Console.WriteLine(num);
            }
        }
    }
}
