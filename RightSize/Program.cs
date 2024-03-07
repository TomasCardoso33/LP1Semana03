using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach ( string s1 in args)
            {
                if (s1.Length > 6)
                {
                    break;
                }
                
                if (s1.Length > 3)
                {
                    Console.WriteLine(s1);
                }
                
            }
        }
    }
}
