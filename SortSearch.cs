using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assignment
{
    public class SortSearch
    {
        public int[] Algorithm(int[] numbers, int count)
        {
            int temp;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                //nested for loop
                for (int j = 0; j < numbers.Length - (1 + i); j++)
                {
                    count++;
                    if (numbers[j] > numbers[j + 1])
                    {

                        temp = numbers[j + 1];
                        //temp file to place j+1 to be swapped later
                        numbers[j + 1] = numbers[j];
                        //j + 1 has now been swapped for j so now J will be in temp and move into the old position J+1 was in.
                        numbers[j] = temp;
                    }
                    count++;
                    //steps taken added for entire operation.
                }
            }
            Console.WriteLine("Total steps taken for the bubblesort are: " + count);
            return numbers;
        }
        public int[] ReverseBubbleSort(int[] numbers, int count)
        {
            int temp;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                //nested for loop
                for (int j = 0; j < numbers.Length - (1 + i); j++)
                {
                    count++;
                    if (numbers[j] > numbers[j + 1])
                    {

                        temp = numbers[j + 1];
                        //temp file to place j-1 to be swapped later
                        numbers[j + 1] = numbers[j];
                        //j - 1 has now been swapped for j so now J will be in temp and move into the old position J-1 was in.
                        numbers[j] = temp;
                        //J now becomes new temp file instead of j-1, this depicts that -
                        //- it is sorting the array in descending order by making the large values starting first.
                    }
                    count++;
                    //steps taken added for entire operation.
                }
            }
            Console.WriteLine("Total steps taken for the bubblesort are: " + count);
            return numbers;
        }
    }
}

