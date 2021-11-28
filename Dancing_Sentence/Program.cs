using System;

namespace Dancing_Sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string dance = @"ThIs Is A dAnCiNg SeNtEnCe
  ThIs Is         A dAnCiNg   SeNtEnCe
AaAaAaAaAaA
Z";
            string final = "";
            
            bool upper = true;
            for (int i = 0; i < dance.Length; i++)
            {
                if (dance[i] != ' ')
                {
                    if((dance[i]) != 13)
                    {
                        if (dance[i] >= 65 && dance[i] <= 90)
                        {
                            final += upper ? dance[i] : (char)(dance[i] + 32);
                            upper = !upper;
                        }
                        else if (dance[i] >= 97 && dance[i] <= 122)
                        {
                            final += upper ? (char)(dance[i] - 32) : dance[i];
                            upper = !upper;
                        } else
                        {
                            final += dance[i];
                        }
                    }else
                    {
                        upper = true;
                        final += dance[i];
                    }                   
                } else
                {
                    final += dance[i];
                }
            }
            Console.WriteLine(final);
        }
    }
}
