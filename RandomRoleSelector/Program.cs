using System;
using System.Collections.Generic;

namespace RandomRoleSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the League of Legends Random strat creator!");
            var random = new Random();
            var list = new List<string> {"Top", "Jungle", "Mid", "Bot", "Support"};
            int index = random.Next(list.Count);
            Console.WriteLine(list[index]);
            
            
            var champion = new Random();
            var championList = new List<string> {"aatrox", "ahri", "akali", "alistar", "amumu", "anivia", "annie"};
            index = random.Next(championList.Count);
            Console.WriteLine(championList[index]);
            
        }
    }
}