using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zombie_dice
{
    class Game
    {

        static public void StartGame()
        {
            Console.WriteLine("Welcome to Zombie Dice.");
            Console.WriteLine("Type anything to star the game.");
            Console.ReadLine();
            Console.Clear();
            PlayerPresentation();
        }
       
        static private void PlayerPresentation()
        {
            Player[] playerList = CreatePlayer.Create();
            bool game = true;
            while (game)
            {
                foreach (Player player in playerList)
                {
                    bool roundPlayer = true;
                    while (roundPlayer)
                    {
                        Console.WriteLine($"-----------{player.Name}------------");
                        Console.WriteLine("Here are your options of action\n");
                        Console.WriteLine(MenuOptions());
                        var userOption = int.Parse(Console.ReadLine());



                        switch (userOption)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine(player.GetPlayerInfo());
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 2:
                                player.DiceFromTheBox();
                                Console.Clear();
                                player.GetCurrentDice();
                                player.playerInput();
                                player.ShowFaces();
                                player.DiscartDice();

                                break;

                            case 3:
                                StaticDice.ShowDiceList();
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 4:
                                player.EndRound();
                                roundPlayer = false;
                                Console.Clear();
                                break;

                        }
                        roundPlayer = player.CheckShots();
                    }
                }
            }
            
        }
        static private string MenuOptions()
        {
            var str1 = "____________________________________\n\n\n";
            var str2 = "1. See your current info\n";
            var str3 = "2. Get the dice from the box. \n";
            var str4 = "3. Show the dice in the box. \n";
            var str5 = "4. End your turn\n";
            var str6 = "_____________________________________\n";

            return str1 + str2 + str3 + str4 + str5 + str6;
        }

    }
}


