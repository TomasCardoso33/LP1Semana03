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
            string [][] players = new string [n][];
            for (int i= 0;  i < players.Length; i++)
            {
                string i2 = i.ToString();
                Console.WriteLine("O jogador tem DefeatOptionalBoss? s/n: ");
                string ans1 = Console.ReadLine();
                Console.WriteLine("O jogador tem FindHiddenLevel? s/n: ");
                string ans2 = Console.ReadLine();
                Console.WriteLine("O jogador tem FinishGame? s/n: ");
                string ans3 = Console.ReadLine();
                if (ans1 == "s" && ans2 == "s" && ans3 == "s")
                    {
                        players[i] = new string [4] {"DefeatOptionalBoss", "FindHiddenLevel", "FinishGame", "Completionist!" };

                    }
                else if (ans1 == "s" && ans2 == "s" && ans3 == "n")
                        {
                            players[i] = new string [2] {"DefeatOptionalBoss", "FindHiddenLevel"};
                        }
                else if (ans1 == "s" && ans2 == "n" && ans3 == "n")
                        {
                            players[i] = new string [1] {"DefeatOptionalBoss"};
                        }
                else if (ans1 == "n" && ans2 == "s" && ans3 == "s")
                        {
                            players[i] = new string [2] {"FindHiddenLevel", "FinishGame"};
                        }
                else if (ans1 == "n" && ans2 == "s" && ans3 == "n")
                        {
                            players[i] = new string [1] {"FindHiddenLevel"};
                        }
                else if (ans1 == "n" && ans2 == "n" && ans3 == "s")
                        {
                            players[i] = new string [1] {"FinishGame"};
                        }
                else if (ans1 == "s" && ans2 == "n" && ans3 == "s")
                        {
                            players[i] = new string [2] {"DefeatOptionalBoss", "FinishGame"};
                        }
                Console.WriteLine(string.Join("\n",players[i]));    

            }
            
            

                    
                
        }
    }
}
