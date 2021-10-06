using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zombie_dice
{
     public class CreatePlayer
    {
        static public Player[] Create()
        {
            Player[] playerList = new Player[3];
            Console.WriteLine("How many players are there?");
            var playerNumber = Console.ReadLine();
            var playerNumberInt = int.Parse(playerNumber);
            Console.Clear();

            for (int i = 0; i < playerNumberInt; i++)
            {
                Console.WriteLine($"Please, write the name of the {i +1}º player:");
                playerList[i] = new Player(Console.ReadLine());
                Console.Clear();
                
            }
            return playerList;
        }
        

    }
}
