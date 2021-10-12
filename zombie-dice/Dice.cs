using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zombie_dice
{
    public class Dice
    {
        //the die object is gonna be put into a list of dice and then accessed to it can be thrown
        public string Color;
        public string[] Features = new string[6];
        public string Face;


        public Dice(string color, string[] features)
        {
            Color = color;
            Features = features;
        }

        //a method to return me 13 dice that I'll need for the game
        static public List<Dice> GetDice()
        {
            string[] redDiceFeatures = { "brain", "shot", "shot", "shot", "run", "run" };
            Dice Dice1 = new Dice("red", redDiceFeatures);
            Dice Dice2 = new Dice("red", redDiceFeatures);
            Dice Dice3 = new Dice("red", redDiceFeatures);

            string[] yellowDiceFeatures = { "brain", "brain", "shot", "shot", "run", "run" };
            Dice Dice4 = new Dice("yellow", yellowDiceFeatures);
            Dice Dice5 = new Dice("yellow", yellowDiceFeatures);
            Dice Dice6 = new Dice("yellow", yellowDiceFeatures);
            Dice Dice7 = new Dice("yellow", yellowDiceFeatures);

            string[] greenDiceFeatures = { "brain", "brain", "brain", "shot", "run", "run" };
            Dice Dice8 = new Dice("green", greenDiceFeatures);
            Dice Dice9 = new Dice("green", greenDiceFeatures);
            Dice Dice10 = new Dice("green", greenDiceFeatures);
            Dice Dice11 = new Dice("green", greenDiceFeatures);
            Dice Dice12 = new Dice("green", greenDiceFeatures);
            Dice Dice13 = new Dice("green", greenDiceFeatures);

            List<Dice> listDice = new List<Dice> {Dice1, Dice2, Dice3, Dice4, Dice5, Dice6, Dice7, Dice8, Dice9, Dice10, Dice11, Dice12, Dice13 };

            return listDice;
        }
        
        
        

    }

    
}


