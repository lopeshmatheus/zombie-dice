using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zombie_dice
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Brains { get; set; }
        public int Shots { get; set; }
        public int Runs { get; set; }
        public List<Dice> CurrentDice { get; set; } = new List<Dice>();

        public Player(string name)
        {
            Name = name;
            Score = 0;

        }
        public string GetPlayerInfo()
        {
            var string1 = $"You have {this.Score} points in total\n";
            var string2 = $"You are holding {this.Brains} brains in this turn.\n";
            var string3 = $"You received {this.Shots} shots.\n";
            var string4 = $"You have {this.Runs} runs in your hand\n";
            var string5 = "__________________________________________________";
            var fullstring = string1 + string2 + string3 + string4 + string5;
            return fullstring;


        }

        public void GetCurrentDice()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Here are the dice you got: \n");
            foreach (Dice i in this.CurrentDice)
            {
                Console.WriteLine($"{i.Color}\n");
            }
            Console.WriteLine("--------------------------");
            Console.ReadLine();
            Console.Clear();

            
            
        }
        //this function is going to take 3 dice from the box and show the color to the player
        public void DiceFromTheBox()
        {
            var diceList = Dice.GetDice();
            var randomList = RandomNumber.RandomGen(diceList.Count);
            var randomIndex = 0;

            for(int i = 0; i < 3; i++)
            {
                randomIndex = randomList.First();
                this.CurrentDice.Add(diceList[randomIndex]);
                diceList.RemoveAt(randomIndex);
                randomList.RemoveAt(randomIndex);


            }
          

        }
        public void SortDiceFromTheBox()
        {
            foreach(Dice die in this.CurrentDice)
            {

            }
        }
        
    }
  

}
