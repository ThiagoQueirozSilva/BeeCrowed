using System;

namespace Subsequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases;

            testCases = int.Parse(Console.ReadLine());

            for(int i = 0; i < testCases; i++)
            {
                string tCase = Console.ReadLine();
                int queries = int.Parse(Console.ReadLine());

                for(int j = 0; j < queries; j++)
                {
                    string query = Console.ReadLine();
                    string compare = "";
                    int queryPos = 0;
                    foreach (var c in tCase)
                    {
                        if (c == query[queryPos])
                        {
                            compare += c;
                            queryPos++;
                            if (queryPos >= query.Length)
                            {
                                break;
                            }
                        }
                    }
                    if (compare.Equals(query))
                    {
                        Console.WriteLine("Yes");
                    }else
                    {
                        Console.WriteLine("No");
                    }
                }

            }
        }
    }
}
