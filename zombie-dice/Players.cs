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
            
            
            
           
            var rnd = new Random();
            

            for (int i = this.CurrentDice.Count; i < 3; i++)
            {
                int rndIndex = rnd.Next(0, StaticDice.diceList.Count - 1);
                this.CurrentDice.Add(StaticDice.diceList[rndIndex]);
                StaticDice.diceList.RemoveAt(rndIndex);
                StaticDice.garbageDiceList.Add(StaticDice.diceList[rndIndex]);

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
                Console.WriteLine($"{die.Face}\n");
            }

        }
        public void playerInput()
        {
            Console.WriteLine("Do you want to throw the dice?\n1. Yes.\n2. No.\n");
            

            string playerAnswer = Console.ReadLine();
            playerAnswer = playerAnswer.ToLower();

            switch(playerAnswer)
            {
                case "1":
                    Console.Clear();
                    this.SortDiceFromTheHand();                  
                    break;
                case "2":
                    break;
            }
        }
        public void ShowResults()
        {
            Console.WriteLine($"You've got:\n");
            foreach (Dice die in this.CurrentDice)
            {
                Console.WriteLine($"{die.Face}\n");
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
            }
            Console.ReadLine();
            Console.Clear();
        }
        public void EndRound()
        {
            this.Score += this.Brains;

        }
        public bool CheckShots()
        {
            if (this.Shots >= 3)
            {
                this.Brains = 0;
                Console.WriteLine($"That's a bummer! You just got {this.Shots} shots!\n You're dead! Next player's round!");
                
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
