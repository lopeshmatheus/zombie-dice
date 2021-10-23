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
        
        public string Color { get; private set; }
        public string[] Features { get; private set; }
        public string Face;

        private const string b = "brain";
        private const string s = "shot";
        private const string r = "run";
        
        public static readonly Dice RED = new Dice("red", s, s, s, r, r, b);
        public static readonly Dice YELLOW = new Dice("yellow", b, b, s, s, r, r);
        public static readonly Dice GREEN = new Dice("green", b, b, b, s, r, r);

        public Dice(string color, params string[] features)
        {
            Color = color;
            Features = features;
        }
            

        //a method to return me 13 dice that I'll need for the game
        static public List<Dice> GetDice()
        {
            List<Dice> diceList = new List<Dice>();
            
            for (int i = 0; i < 3; i++)
                diceList.Add(RED);
          
            for (int i =0; i < 4; i++)
                diceList.Add(YELLOW);

            for (int i = 0; i < 6; i++)
                diceList.Add(GREEN);         

            return diceList;
        }
        
        
        

    }

    
}


