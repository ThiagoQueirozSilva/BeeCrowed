using System;
using System.Collections.Generic;


namespace Tell_Me_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Frequency> lista = new List<Frequency>();
            string frase;
            Boolean first = true;

            while ((frase = Console.ReadLine()) != null)
            {
                if (!first)
                {
                    Console.WriteLine("");
                }
                for(int i = 0; i < frase.Length; i++)
                {
                    int counter = 0;
                    char letter = frase[i];
                    foreach (char c in frase)
                    {
                        if(c == letter)
                        {
                            counter++;
                        }
                    } 
                    frase = frase.Replace(letter,(char) 0);
                    Frequency freq = new Frequency(letter, counter);
                    lista.Add(freq);
                }
                lista.Sort();
                foreach (Frequency frequency in lista)
                {
                    if(frequency.Code != 0)
                    {
                        Console.WriteLine(frequency.Code + " "+ frequency.Quantity);
                    }
                }
                first = false;
                lista.Clear();
            }
        }
    }
    class Frequency : IComparable
    {
        public int Quantity { get; set; }
        public int Code { get; private set; }
        public Frequency(int ascii,int repetitions)
        {
            Quantity = repetitions;
            Code = ascii;
        }
        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 1;
            }
            Frequency otherTest = obj as Frequency; 
            if(otherTest != null)
            {
                if(otherTest.Quantity == this.Quantity)
                {
                    if(otherTest.Code > this.Code)
                    {
                        return 1;
                    } else
                    {
                        return -1;
                    }
                }
                return this.Quantity.CompareTo(otherTest.Quantity);
            } else
            {
                throw new ArgumentException("Object is not a frequency");
            }
        }
    }
}
