using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve qualquer coisa:  ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Escreva uma letra");
            string s2 = Console.ReadLine();
            string s4 ="";
            foreach(string s3 in s1)
            {
                s4 += s3;
                if ( s3 == s2)
                {
                    s4+= "X";
                }
                else
                {
                    s4+=s3;
                }
                
            }
            Console.WriteLine(s4);
            
        }
    }
}
