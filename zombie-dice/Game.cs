using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zombie_dice
{
    class Game
    {
        //the main function of the program, the game is gonna be running here
        static public void StartGame()
        {
            Console.WriteLine("Welcome to Zombie Dice.\n\n");
            Rules();
            Console.ReadLine();
            Console.Clear();
            PlayerPresentation();
        }
       //will iterate through each player in the list forever until it is stopped
        static private void PlayerPresentation()
        {
            Player[] playerList = CreatePlayer.Create();

            bool game = true;
            while(game)
            {
                foreach (Player player in playerList)
                {   
                    
                    restart:
                    Console.WriteLine($"-----------{player.Name}------------");
                    Console.WriteLine("Here are your options of action\n");
                    Console.WriteLine(MenuOptions());
                    try
                    {
                        var userOption = int.Parse(Console.ReadLine());

                        switch (userOption)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine(player.GetPlayerInfo());
                                Console.ReadLine();
                                Console.Clear();
                                goto restart;

                            case 2:
                                player.DiceFromTheBox();
                                if (player.Brains >= 13)
                                {
                                    Console.Clear();
                                    player.EndGame();
                                }
                                Console.Clear();
                                player.GetCurrentDice();
                                player.SortDiceFromTheHand();
                                player.ShowFaces();
                                player.DiscartDice();

                                if (player.Shots >= 3)
                                {
                                    player.LoseRound();
                                    break;
                                }

                                goto restart;

                            case 3:
                                StaticDice.ShowDiceList();
                                Console.ReadLine();
                                Console.Clear();
                                goto restart;

                            case 4:
                                Console.Clear();
                                Rules();
                                Console.ReadLine();
                                Console.Clear();
                                goto restart;
                                

                            case 5:
                                player.EndRound();
                                //roundPlayer = false;                               
                                Console.Clear();
                                if (player.Score >= 13)
                                {
                                    Console.WriteLine($"Congratulations! {player.Name} won");
                                    game = false;
                                }
                                break;


                        }
                    }
                    catch
                    {
                        Console.Clear();
                        goto restart;
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
            var str5 = "4. Rules.\n";
            var str6 = "5. End your turn\n";
            var str7 = "_____________________________________\n";

            return str1 + str2 + str3 + str4 + str5 + str6 + str7;
        }
        static private void Rules()
        {
            
            Console.WriteLine("\nYou are a zombie! Go there and get some braaaains\n");
            Console.WriteLine("1. The first player to get to 13 points will win and the game will be over.");
            Console.WriteLine("2. You get points by getting brains.");
            Console.WriteLine("3. Every time the round finished all of your brains will transforme into score points.");
            Console.WriteLine("4. Beware! If you get 3 shots in the same round you will lose all of your brains and loose the round");
            Console.WriteLine("5. I your victim ran (run dice) that means you get to throw the same dice in the next round");
            Console.WriteLine("6. And for the last, remember: BRAAAAAAAINS!");

        }
    }
}


