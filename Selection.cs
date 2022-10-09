using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_Assignment
{
    public class Selection
    {
        public int[] SelectionSort(int[] numbers, int count)
        {
            //use a steps counter to show all the steps taken in the code
            for (var i = 0; i < numbers.Length; i++)
            {
                var minimumVal = i;
                //for loop allows to iterate through the array which is unsorted to support finding lowest value.
                for(var j = i + 1; j < numbers.Length; j++)
                {
                    count++;
                    //counting steps taken for each operation finished.
                    if (numbers[minimumVal] > numbers[j])
                    {
                        //makes a splitted array, if minimum value is greater than the numbers in the array-
                        //lowest element is found and become J.
                        minimumVal = j;
                    }    
                }
                if(minimumVal != i)
                {
                    var lowVal = numbers[minimumVal];
                    //when it finds the lowest value element within entire array array, it will swap the lowest element-
                    //found in the array for the actual lowest value found in the enitre array.
                    numbers[minimumVal] = numbers[i];
                    numbers[i] = lowVal;
                }
                
                
            }
            Console.WriteLine("Total amount of steps taken to sort with selection is:" + count);
            return numbers;

        }
        public int[] ReverseSelectionSort(int[] numbers, int count)
        {
         
            for (var i = 0; i < numbers.Length; i++)
                {
                var maxVal = i;
                //for loop allows to iterate through the array which is unsorted to support finding lowest value.
                for (var j = i + 1; j < numbers.Length; j++)
                    {
                        count++;
                    //counting steps taken for each operation finished.
                    if (numbers[maxVal] < numbers[j])
                    {
                        //makes a splitted array, if maximum value is lower than the numbers in the array-
                        //highest element is found and become J.
                        maxVal = j;
                    }
                }
                
                if (maxVal != i)
                {
                    var lowVal = numbers[maxVal];
                    //when it finds the highest value element within entire array array, it will swap the highest element-
                    //found in the array for the actual highest value found in the enitre array.
                    numbers[maxVal] = numbers[i];
                    numbers[i] = lowVal;
                }


            }
            Console.WriteLine("Total amount of steps taken to sort with selection is:" + count);
            return numbers;
        }
    }
}
