using System;
using System.Collections.Generic;

namespace Sort_By_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStrings;
            string[] strings;
            string word = " ";


            numberStrings = int.Parse(Console.ReadLine());
            strings = new string[numberStrings];

            for (int i = 0; i < numberStrings; i++)
            {
                strings[i] = Console.ReadLine();
            }

            for (int i = 0; i < numberStrings; i++)
            {
                List<string> frase = new List<string>();
                for (int j = 0; j < strings[i].Length; j++)
                {
                    if(strings[i][j] != ' ')
                    {
                        word += strings[i][j];
                    } else
                    {

                        frase.Add(word);
                        word = "";
                    }
                }
                frase.Add(word);
                word = "";
                frase.Sort((x, y) => y.Length.CompareTo(x.Length));
                frase.ForEach(delegate (String word)
                {
                    Console.Write(word+" ");
                });
                Console.WriteLine("");
            }
        }
    }
}
