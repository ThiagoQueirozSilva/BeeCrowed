using System;
using System.Collections.Generic;

namespace Sort_By_Length2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStrings;
            string entry;
            string[] words;
            List<String> listOfWords = new List<String>();

            numberStrings = int.Parse(Console.ReadLine());
         

            for (int i = 0; i < numberStrings; i++)
            {
                entry = Console.ReadLine();
                words = entry.Split(' ');
                listOfWords = new List<String>();
                foreach(string word in words)
                {
                    listOfWords.Add(word);
                }
                while(listOfWords.Count > 0)
                {
                    string bigger = "";
                    foreach(String word in listOfWords)
                    {
                        if(word.Length > bigger.Length)
                        {
                            bigger = word;
                        }
                    }
                    Console.Write(bigger);
                    listOfWords.Remove(bigger);
                    if(listOfWords.Count > 0)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            


        }
    }
}
