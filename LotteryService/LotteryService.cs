using System;
using System.Collections.Generic;

namespace LotteryService
{
    public class Class1
    {
        public int[] SortNumbers(int[] lotteryNums)
        {
            // lotteryNums = new int[0];

            Array.Sort(lotteryNums);
            foreach(var num in lotteryNums)
            {
                 Console.WriteLine("Sorted Numbers: " + num);
            }
            //Console.WriteLine(lotteryNums);
            return lotteryNums;
            
        }
    }
}
