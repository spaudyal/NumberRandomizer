﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGenerator
{
    public class ArrayShuffler
    {
        /// <summary>
        /// Here, an array element can change its value only once
        /// Start loop with an initial data
        /// Swap the items from randomly chosen position and current index (from entire array)
        /// Then swap number from randomly chosen position and current index (from remaining array excluding lastly swapped position)
        /// This way, every time we swap with random number generated from remaining array only 
        /// </summary>
        public void DoOptimalShuffle(int[] data)
        {
            for (int index = data.Length - 1; index > 0; index--)
            {
                int randomPosition = new Random().Next(index+1);
                (data[index], data[randomPosition]) = (data[randomPosition], data[index]);
            }
        }

        /// <summary>
        /// Here, an array element can change its value many times
        /// Loop through each number in the data
        /// Swap the number in randomly chosen position in entire current array with current index number
        /// </summary>
        public void DoSimpleShuffle(int[] data)
        {
            for (int index = data.Length - 1; index > 0; index--)
            {
                int randomPosition = new Random().Next(data.Length);
                (data[randomPosition], data[index]) = (data[index], data[randomPosition]);
            }
        }
    }
}
