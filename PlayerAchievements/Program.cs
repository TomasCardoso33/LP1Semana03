using System;

namespace PlayerAchievements
{
     [Flags]
public enum Achievements
{
    None = 0,
    DefeatOptionalBoss = 1,
    FindHiddenLevel = 2,
    FinishGame = 4
}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o número de jogadores: ");
            string s1 = Console.ReadLine();
            int n = int.Parse(s1);
            Console.WriteLine(n);
        }
    }
}
