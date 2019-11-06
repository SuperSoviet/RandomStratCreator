using System;
using System.Collections.Generic;

namespace RandomStratCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Select a random champion");
            Console.WriteLine("2) Select a random role" );
            Console.WriteLine("3) Select a random strat");
            Console.WriteLine("4) Select a random role and champion");
            
            string userInput;
            do 
            {
                Console.Write("\r\nSelect an option: ");
                userInput = Console.ReadLine();

            } while (!int.TryParse(userInput, out int chosenMenuItem));

        }

        private static void SelectRandomChampAndRole()
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