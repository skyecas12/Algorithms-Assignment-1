using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assignment
{
    class reverse
    {
        public int[] reverseArr(int[] numbers)
        {
            int count = 0;
            int num = numbers.Length;
            for (int i = 0; i < num / 2; i++)
            {
                count++;
                int temp = numbers[i];
                numbers[i] = numbers[num - i - 1];
                numbers[num - i - 1] = temp;
            }
            return numbers;
        }
    }
}
