using System;

namespace Dancing_Sentence2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry,result;
            bool upper;

           
            while ((entry = Console.ReadLine()) != null)
            {
                upper = true;
                result = "";
                for (int i = 0; i < entry.Length; i++)
                {
                    if (entry[i] != ' ')
                    {
                        if (entry[i] >= 65 && entry[i] <= 90)
                        {
                            result += upper ? entry[i] : (char)(entry[i] + 32);
                            upper = !upper;
                        }
                        else if (entry[i] >= 97 && entry[i] <= 122)
                        {
                            result += upper ? (char)(entry[i] - 32) : entry[i];
                            upper = !upper;
                        }
                        else
                        {
                            entry += entry[i];
                        }
                    } else
                    {
                        result += entry[i];
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
