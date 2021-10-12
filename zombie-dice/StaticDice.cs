using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zombie_dice
{
    class StaticDice
    {
        static public List<Dice> diceList = Dice.GetDice();
        static public List<Dice> garbageDiceList = new List<Dice> { };

        static public void ShowDiceList()
        {
            foreach(Dice die in diceList)
            {
                Console.WriteLine($"{die.Color}\n");
            }
        }
    }
}
