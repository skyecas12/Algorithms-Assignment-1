using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assignment
{
    public class LinearSearch
    {
        public int Linear(int[] numbers, int key, int count)
        {
            bool exist = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                count++;
                if (numbers[i] == key)
                {
                    //if the number is equal to the key (user input in main program) - 
                    //then it will continue to print out all index position the value exists while it is true.
                    Console.WriteLine("The index position of the value entered is at: " + i);
                    exist = true;
                    //each step taken to complete the operation.
                }
            }
            if (!exist)
            {
                //if it does not exist (false//exist is NOT true) then the value will not exist within the array chosen.
                Console.WriteLine("The value does not exist within the array parameter");
            }
            Console.WriteLine("Total steps taken to complete operation is: " + count);

            return -1;
        }
    }
}
