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

        ConsoleColor red = ConsoleColor.Red;
        ConsoleColor yellow = ConsoleColor.Yellow;
        ConsoleColor green = ConsoleColor.Green;

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
                if (i.Color == "red")
                {
                    Console.ForegroundColor = red;
                    Console.WriteLine($"{i.Color.ToUpper()}\n");
                    Console.ResetColor();
                }
                else if (i.Color == "yellow")
                {
                    Console.ForegroundColor = yellow;
                    Console.WriteLine($"{i.Color.ToUpper()}\n");
                    Console.ResetColor();
                }
                else if (i.Color == "green")
                {
                    Console.ForegroundColor = green;
                    Console.WriteLine($"{i.Color.ToUpper()}\n");
                    Console.ResetColor();
                }

            }
            Console.WriteLine("--------------------------");
            Console.ReadLine();
            Console.Clear();



        }
        //this function is going to take 3 dice from the box and show the color to the player
        public void DiceFromTheBox()
        {                      
            var rnd = new Random();           
            for (int i = this.CurrentDice.Count; i < 3; i++)
            {
                int rndIndex = rnd.Next(0, StaticDice.diceList.Count - 1);
                this.CurrentDice.Add(StaticDice.diceList[rndIndex]);
                StaticDice.garbageDiceList.Add(StaticDice.diceList[rndIndex]);
                StaticDice.diceList.RemoveAt(rndIndex);
                
            }

        }
        public void SortDiceFromTheHand()
        {
            var rnd = new Random();
            

            foreach (Dice die in this.CurrentDice)
            {
                int rndCurrentDice = rnd.Next(0, 6);
                die.Face = die.Features[rndCurrentDice];

                switch (die.Face)
                {
                    case "brain":
                        this.Brains++;
                        
                        break;

                    case "shot":
                        this.Shots++;                      
                        break;

                    case "run":
                        this.Runs++;
                        break;

                }

            }




        }
        //this method will show the faces the palyer sorted
        public void ShowFaces()
        {
            Console.Clear();           
            foreach (Dice die in this.CurrentDice)
            {
                              
                
                if (die.Color == "red")
                {
                    Console.ForegroundColor = red;
                    Console.WriteLine($"{die.Face.ToUpper()}\n");
                    Console.ResetColor();
                }
                else if (die.Color == "yellow")
                {
                    Console.ForegroundColor = yellow;
                    Console.WriteLine($"{die.Face.ToUpper()}\n");
                    Console.ResetColor();
                }
                else if (die.Color == "green")
                {
                    Console.ForegroundColor = green;
                    Console.WriteLine($"{die.Face.ToUpper()}\n");
                    Console.ResetColor();
                }
            }
            

        }      
      
        public void DiscartDice()
        {
            for (int i = this.CurrentDice.Count - 1; i >= 0; i--)
            {
                if (this.CurrentDice[i].Face != "run")
                {
                    this.CurrentDice.RemoveAt(i);
                }
                else
                {
                    continue;
                }
            }
            Console.ReadLine();
            Console.Clear();
            
        }
        public void EndRound()
        {
            Console.Clear();
            Console.WriteLine("You chose to finish your round.\nHere is your info:\n");
            Console.WriteLine(this.GetPlayerInfo());
            Console.ReadLine();
       

            this.Score += this.Brains;
            this.Brains = 0;
            this.Shots = 0;
            this.Runs = 0;
            this.CurrentDice.Clear();
            foreach (Dice die in StaticDice.garbageDiceList)
            {
                StaticDice.diceList.Add(die);
            }
            StaticDice.garbageDiceList.Clear();

            
        }
        public void LoseRound()
        {
            Console.Clear();
            Console.ForegroundColor = red;
            Console.WriteLine("POW! You've just been shot! Leave all your brain on the table.\n\n");
            Console.ResetColor();
            this.Brains = 0;
            this.Runs = 0;
            Console.WriteLine(this.GetPlayerInfo());
            Console.ReadLine();
            Console.Clear();
            this.Shots = 0;
            this.CurrentDice.Clear();

            foreach (Dice die in StaticDice.garbageDiceList)
            {
                StaticDice.diceList.Add(die);
            }
            StaticDice.garbageDiceList.Clear();
        }
        public void EndGame()
        {
            Console.WriteLine($"Congratulations!{this.Name} You've eaten 13 brains and won the game!");
            
        }
        
        
    }
}
