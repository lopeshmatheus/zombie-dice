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
            Console.WriteLine("_______________________");
            Player[] playerList = CreatePlayer.Create();

            for (int i = 0; i < playerList.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine($"It's {playerList[i].Name}'s time!");
                    Console.WriteLine("Here is your information now: ");
                    Console.WriteLine(playerList[i].GetPlayerInfo());
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("What do you want to do next?");
                    Console.WriteLine("1.Get the dice from the box.");
                    Console.WriteLine("2.See my info again");
                    Console.WriteLine("3.Finish your turn.");
                    var userAnswer = Console.ReadLine();
                    var diceArray = Dice.GetDice().ToArray();
                    var rndArray = RandomNumber.RandomGen(13);

                    switch (userAnswer)
                    {
                        case "1":

                            playerList[i].CurrentDice[1] = diceArray[rndArray[1]];
                            
                           

                            break;


                        case "2":
                            playerList[i].GetPlayerInfo();
                            break;

                    }
                }

            }    
        }
    }
}
