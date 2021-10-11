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
        public int Brain;
        public int Shot;
        public int Run;


        public Dice(string color, int brain, int shot, int run)
        {
            Color = color;
            Brain = brain;
            Shot = shot;
            Run = run;


        }

        //a method to return me 13 dice that I'll need for the game
        static public List<Dice> GetDice()
        {
            Dice redDice1 = new Dice("red", 1, 3, 2);
            Dice redDice2 = new Dice("red", 1, 3, 2);
            Dice redDice3 = new Dice("red", 1, 3, 2);

            Dice yellowDice1 = new Dice("yellow", 2, 2, 2);
            Dice yellowDice2 = new Dice("yellow", 2, 2, 2);
            Dice yellowDice3 = new Dice("yellow", 2, 2, 2);
            Dice yellowDice4 = new Dice("yellow", 2, 2, 2);

            Dice greenDice1 = new Dice("green", 3, 1, 2);
            Dice greenDice2 = new Dice("green", 3, 1, 2);
            Dice greenDice3 = new Dice("green", 3, 1, 2);
            Dice greenDice4 = new Dice("green", 3, 1, 2);
            Dice greenDice5 = new Dice("green", 3, 1, 2);
            Dice greenDice6 = new Dice("green", 3, 1, 2);

            List<Dice> listDice = new List<Dice> { redDice1, redDice2, redDice3, yellowDice1, yellowDice2,yellowDice3,yellowDice4,
            greenDice1, greenDice2, greenDice3, greenDice4, greenDice5};

            return listDice;
        }
        
        
        

    }

    
}


