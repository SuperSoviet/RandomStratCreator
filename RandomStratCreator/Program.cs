using System;
using System.Collections.Generic;

namespace RandomStratCreator {
  class Program {
    // fields
    private static bool _shouldExit;
    static void Main(string[] args) {
      MainMenu();
    }

    private static void MainMenu() {
      OptionsMenu();
    }

    private static void OptionsMenu() {
      Console.WriteLine("Welcome to the League of Legends Random strat creator!");
      while (!_shouldExit) {
        Console.WriteLine("[--------------------------------------------]");
        Console.WriteLine("|               Choose an option:            |");
        Console.WriteLine("|                                            |");
        Console.WriteLine("|1) Selects a random champion                |");
        Console.WriteLine("|2) Selects a random role                    |");
        Console.WriteLine("|3) Selects a random strat                   |");
        Console.WriteLine("|4) Selects a random role and champion       |");
        Console.WriteLine("|5) Randomly gives you one of the options    |");
        Console.WriteLine("|6) Exit program                             |");
        Console.WriteLine("[--------------------------------------------]");

        string userInput;
        int chosenMenuItem;
        do {
          Console.Write("\r\nSelect an option: ");
          userInput = Console.ReadLine();
        } while (!int.TryParse(userInput, out chosenMenuItem));

        DoMenu(chosenMenuItem);



        Console.WriteLine("Press any button to continue...");
        Console.ReadKey(true);
        Console.Clear();
      }
    }

    private static void DoMenu(int chosenMenuItem) {
      if (chosenMenuItem == 1) {
        SelectRandomChampion();
      }

      if (chosenMenuItem == 2) {
        SelectRandomRole();
      }

      if (chosenMenuItem == 3) {
        RandomStrats();
      }

      if (chosenMenuItem == 4) {
        SelectRandomChampAndRole();
      }
      if (chosenMenuItem == 6) {
        _shouldExit = true;
      }

      if (chosenMenuItem == 69420) {
        SelectSecret();
      }

      if (chosenMenuItem == 5) {
        Random choosebetweenmenu = new Random();
        int cbmInt = choosebetweenmenu.Next(1, 4);
        DoMenu(cbmInt);

      }
    }

    private static void SelectSecret() {
      Console.WriteLine("You found me :D");
    }

    private static void SelectRandomChampAndRole() {
      SelectRandomRole();


      SelectRandomChampion();
    }

    private static void SelectRandomRole() {
      var random = new Random();
      var list = new List<string> { "Top", "Jungle", "Mid", "Bot", "Support" };
      int index = random.Next(list.Count);
      Console.WriteLine(list[index]);
    }

    private static void SelectRandomChampion() {
      var random = new Random();
      var championList = new List<string> { "Aatrox", "Ahri", "Akali", "Alistar", "Amumu", "Anivia", "Annie" };
      var index = random.Next(championList.Count);
      Console.WriteLine(championList[index]);
    }

    private static void RandomStrats() {
      var random = new Random();
      var list = new List<string>
      {
                "Do the Tyler1 : Run it down Mid",
                "Kayn main at heart : Play Rhaast but use shadow assassin items and runes",
                "Vayne is my main : Play full AD Vayne",
                "Helping my team from the jungle : Play a support in the jungle",
                "0 Deaths : try to have no deaths even if it causes your team to die"
      };
      int index = random.Next(list.Count);
      Console.WriteLine(list[index]);

    }
  }
}

