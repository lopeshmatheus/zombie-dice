using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zombie_dice
{
    static class StaticDice
    {
        static public List<Dice> diceList = Dice.GetDice();
        static public List<Dice> garbageDiceList = new List<Dice> { };

        static public void ShowDiceList()
        {
            Console.Clear();
            Console.WriteLine($"There are {diceList.Count} dice in the box\n\n");
            foreach(Dice die in diceList)
            {
                Console.WriteLine($"{die.Color}\n");
            }
        }
    }
}
