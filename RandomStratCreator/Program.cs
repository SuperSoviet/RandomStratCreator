using System;
using System.Collections.Generic;

namespace RandomStratCreator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("Welcome to the League of Legends Random strat creator!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Select a random champion");
            Console.WriteLine("2) Select a random role");
            Console.WriteLine("3) Select a random strat");
            Console.WriteLine("4) Select a random role and champion");

            string userInput;
            int chosenMenuItem;
            do
            {
                Console.Write("\r\nSelect an option: ");
                userInput = Console.ReadLine();

            } while (!int.TryParse(userInput, out chosenMenuItem));

            if (chosenMenuItem == 1)
            {
                selectRandomChampion();
            }

            if (chosenMenuItem == 2)
            {
                selectRandomrole();
            }

            if (chosenMenuItem == 3)
            {
                randomStrats();
            } 
            if (chosenMenuItem == 4)
            {
                SelectRandomChampAndRole();
            }

        }

        private static void SelectRandomChampAndRole()
        {

            var random = new Random();
            var list = new List<string> {"Top", "Jungle", "Mid", "Bot", "Support"};
            int index = random.Next(list.Count);
            Console.WriteLine(list[index]);


            var champion = new Random();
            var championList = new List<string> {"aatrox", "ahri", "akali", "alistar", "amumu", "anivia", "annie"};
            index = random.Next(championList.Count);
            Console.WriteLine(championList[index]);

        }

        private static void selectRandomrole()
        {
            var random = new Random();
            var list = new List<string> {"Top", "Jungle", "Mid", "Bot", "Support"};
            int index = random.Next(list.Count);
            Console.WriteLine(list[index]);
        }
        
        private static void selectRandomChampion()
        {
            var random = new Random();
            var championList = new List<string> {"aatrox", "ahri", "akali", "alistar", "amumu", "anivia", "annie"};
            int index = random.Next();
            var champion = new Random();
            
            index = random.Next(championList.Count);
            Console.WriteLine(championList[index]);
        }
        private static void randomStrats()
        {
            var random = new Random();
            var list = new List<string> {"Do the Tyler1 : Run it down Mid", "Kayn main at heart : Play Rhaast but use shadow assassin items and runes", "Vayne is my main : Play full AD Vayne", "Helping my team from the jungle : Play a support in the jungle", "0 Deaths : try to have no deaths even if it causes your team to die"};
            int index = random.Next(list.Count);
            Console.WriteLine(list[index]);
        }



    }
}    