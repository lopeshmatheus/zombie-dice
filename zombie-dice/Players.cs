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
        public Dice[] CurrentDice = new Dice[3];

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
        public string GetCurrentDice()
        {
            var string10 = "__________________________________________";
            var string11 = $"You are holding {this.CurrentDice.Length} dice";
            var string12 = "";
            var string13 = "";
            foreach(Dice i in this.CurrentDice)
            {
                string12 += $"{i.Color}, ";
                string13 += $"You got a {i.}";
            }
            var string13 = ".";
            

        }
    }
  

}
