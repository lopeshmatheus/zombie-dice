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
            
            Console.WriteLine("How many players are there?");
            var playerNumber = int.Parse(Console.ReadLine());
            Player[] playerArray = new Player[playerNumber];
            Console.Clear();

            for (int i = 0; i < playerNumber; i++)
            {
                Console.WriteLine($"Please, write the name of the {i +1}º player:");
                playerArray[i] = new Player(Console.ReadLine());
                Console.Clear();
                
            }
            return playerArray;
        }
        

    }
}
