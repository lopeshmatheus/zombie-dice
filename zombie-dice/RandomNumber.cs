using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zombie_dice
{
    class RandomNumber
    {
        static public int[] RandomGen(int maxNumber)
        {
            var nums = Enumerable.Range(0, maxNumber).ToArray();
            var rnd = new Random();

            for (int i = 0; i < nums.Length; ++i)
            {
                int randomIndex = rnd.Next(nums.Length);
                int temp = nums[randomIndex];
                nums[randomIndex] = nums[i];
                nums[i] = temp;
                
               
            }
            return nums;
            
        }



    }
}
