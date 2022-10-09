using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Algorithms_Assignment
{
    class Program
    {
        static void Main()
        {
            SortSearch bubble = new SortSearch();
            LinearSearch linearsearch = new LinearSearch();
            Selection selection = new Selection();
            BinarySearch Binary = new BinarySearch();
            reverse reverseArray = new reverse();
            //Binary search was made, and it exists, however I did not implement it due to it being incomplete.
            //creations of objects for the classes i made
            try
            {
                Console.WriteLine("Please enter file type such as share1, share2 or share3!: ");
                string fileshare = Console.ReadLine();
                //Fileshare is type of file + number they wish, eg share1, or share2 or share3
                Console.WriteLine("Please type size of file such as 256, or 2048!: ");
                string filesize = Console.ReadLine();
                //filesize is the type of size the user wishes to input, such as 256 size, or 2048 size.
                Console.WriteLine("Please enter choice of algorithm, such as bubble sort, selection sort or linear search: ");
                var choiceAlgorithm = Console.ReadLine();
                //choice of algorithm the user wishes to use, such as bubble sort, selection sort, insertion sort, or linear search 
                string filePath = fileshare + filesize;
                //making a try-catch for the entire program to deter errornous output.
                //made a Case statement to use filepath as the input as it is more efficent to do it
                // - this way than traditional if, else if, else statements.
                //if the user input is equal to EG: share1 + 256, then the filepath will recognise -
                // - it as Share_1_256.txt
                switch (filePath)
                {
                    case "share1" + "256":
                        filePath = "Share_1_256.txt";
                        break;
                    case "share1" + "2048":
                        filePath = "Share_1_2048.txt";
                        break;
                    case "share2" + "256":
                        filePath = "Share_2_256.txt";
                        break;
                    case "share2" + "2048":
                        filePath = "Share_2_2048.txt";
                        break;
                    case "share3" + "256":
                        filePath = "Share_3_256.txt";
                        break;
                    case "share3" + "2048":
                        filePath = "Share_3_2048.txt";
                        break;
                }
                int[] intVal;
                string[] stringValArr;
                stringValArr = File.ReadAllLines(filePath);
                intVal = Array.ConvertAll(stringValArr, s => int.Parse(s));
                choiceAlgorithm.ToLower();
                //Made an Int var intVal as well as string variable stringValArr-
                //- The string val reads the file text in from the users choice of filepath into a string array
                //-intval is used to be able to use for an Int array so we can convert the strings in the file-
                //- to integers so we can work with them in sorting and searching operations.

                //using Case swtich statements to determine which sort or search the user chooses.
                //eg: if the user types in bubble sort, it will go through the operation of bubble sort.
                //the choice of a linear search will be offered at the end, however it searches only Unsorted and NOT sorted.
                switch (choiceAlgorithm)
                {
                    case "bubble sort":
                        int count = 0;
                        bubble.Algorithm(intVal, count);
                        var AscendBubbleArr = intVal;
                        //variable made for ascending bubble sort to pass in a for loop and print out-
                        //- every 10th value within sorted array.
                        Console.WriteLine("Ascending with bubble sort: ");
                        for (int i = 0; i < AscendBubbleArr.Length; i+=9)
                        {
                            Console.WriteLine(AscendBubbleArr[i]);
                        }
                        Console.WriteLine("Descending bubble sort: ");
                        var DescendBubbleArr = reverseArray.reverseArr(intVal);
                        //Variable made for descending bubble sort to pass in for loop
                        //it will print out every 10th value within the descended sorted array.
                        for (int i = 0; i < DescendBubbleArr.Length; i += 9)
                        {
                            Console.WriteLine(DescendBubbleArr[i]);
                        }  
                        Console.WriteLine("Would you like to search for a number with Linear search in the sorted array? :");
                        string BubbleReadLine = Console.ReadLine();
                        BubbleReadLine.ToLower();
                        if (BubbleReadLine.Equals("yes"))
                        {
                            //made a readline variable to pass into the if statement, converts to an integer-
                            //so that the usercan see which position their numerical input is at within the array.
                            Console.WriteLine("Please enter a velue to see if it is within the sorted Array!");
                            string BubbleSelection = Console.ReadLine();
                            int Result;
                            Result = Convert.ToInt32(BubbleSelection);
                            int SortedChoice = linearsearch.Linear(intVal, Result, count);
                        }
                        break;
                    case "selection sort":
                        count = 0;
                        selection.SelectionSort(intVal, count);
                        var AscendSelectionArr = intVal;
                        //variable made for ascending selection sort to pass in a for loop and print out-
                        //- every 10th value within sorted array.
                        Console.WriteLine("Ascending with Selection Sort: ");
                        for (int i = 0; i < AscendSelectionArr.Length; i += 9)
                        {
                            Console.WriteLine(AscendSelectionArr[i]);
                        }
                        Console.WriteLine("Descending with Selection Sort: ");
                        var DescendArr = selection.ReverseSelectionSort(intVal, count);
                        //Variable made for descending selection sort to pass in for loop
                        //it will print out every 10th value within the descended sorted array.
                        for (int i = 0; i < DescendArr.Length; i += 9)
                        {
                            Console.WriteLine(DescendArr[i]);
                        }
                        Console.WriteLine("Would you like to search for a number with Linear search in the sorted array? :");
                        string UserReadLine = Console.ReadLine();
                        UserReadLine.ToLower();
                        if (UserReadLine.Equals("yes"))
                        {
                            //made a readline variable to pass into the if statement, converts to an integer-
                            //so that the usercan see which position their numerical input is at within the array.
                            Console.WriteLine("Please enter a velue to see if it is within the sorted Array!");
                            string Selection = Console.ReadLine();
                            int Result;
                            Result = Convert.ToInt32(Selection);
                            int SortedChoice = linearsearch.Linear(intVal, Result, count);
                        }
                        break;
                    case "linear search":
                        Console.WriteLine("Please enter a value to search for");
                        string LinearInput = Console.ReadLine();
                        //made a readline variable to pass into the if statement, converts to an integer-
                        //so that the usercan see which position their numerical input is at within the array.
                        int userInt = Int32.Parse(LinearInput);
                        int steps = 0;
                        int result = linearsearch.Linear(intVal, userInt, steps);
                        break;
                }
            }
            //catches any errornous output, the user will be asked to start again
            catch(Exception)
            {
                Console.WriteLine("Incorrect input occured, please re-start console application! ");
            }

        }
    }
}
