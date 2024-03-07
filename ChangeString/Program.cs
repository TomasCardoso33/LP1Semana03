using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve algo: ");
            string phrase = Console.ReadLine();

            Console.WriteLine("Escreva uma letra: ");
            string letra = Console.ReadLine();

            string x = ("X");

            phrase = phrase.Replace(letra, x);

            Console.WriteLine("" + phrase);
            
        }
    }
}
