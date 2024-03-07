using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string s1 in args)
            {
                float f1 = float.Parse(s1);
                Console.WriteLine(f1);
            }
        }
    }
}
