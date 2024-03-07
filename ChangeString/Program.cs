using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve qualquer coisa:  ");
            string s1 = ReadLine();
            Console.WriteLine("Escreva uma letra");
            string s2 = ReadLine();
            foreach(string s3 in s1)
            {
                if ( s3 == s2)
                {
                    s2 == "X"
                }
            }
        }
    }
}
