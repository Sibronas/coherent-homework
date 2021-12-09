using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskThree
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskThree();
        }

        private static void TaskThree()
        {
            // This is manual way to put number into array
            /*
            var count = int.Parse(Console.ReadLine());

            var intArray = new int[count];

            for (var i = 0; i < count; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }
            */

            Random randomNumberForArrayLenght = new Random();
            Random randomNumberForArrayItems = new Random();
            var intArray = new int[randomNumberForArrayLenght.Next(2, 10)];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = randomNumberForArrayItems.Next(0, 10);
            }

            intArray.ToString();

            PrintMinMaxInnerSum(intArray);
        }

        private static void PrintMinMaxInnerSum(int[] array)
        {
            var arrayAsList = array.ToList();

            var indexOfMin = arrayAsList.IndexOf(arrayAsList.Min());
            var indexOfMax = arrayAsList.LastIndexOf(arrayAsList.Max());

            // Just to show two ways of walidating index of number, but i prefer uncommented one.
            /*
            var count = 0;

            if (indexOfMin > indexOfMax)
            {
                count = indexOfMin - indexOfMax + 1;
            }
            else
            {
                count = indexOfMax - indexOfMin + 1;
            }
            */

            var count = indexOfMin > indexOfMax
                ? indexOfMin - indexOfMax + 1
                : indexOfMax - indexOfMin + 1;

            // Just to show two ways of validating index of number, but i prefer uncommented one.
            /*
            var startIndex = 0;

            if (indexOfMin > indexOfMax)
            {
                startIndex = indexOfMax;
            }
            else
            {
                startIndex = indexOfMin;
            }
            */

            var startIndex = indexOfMin > indexOfMax
                ? indexOfMax
                : indexOfMin;

            var range = arrayAsList.GetRange(startIndex, count);

            var sum = range.Sum();

            // All the Console.WriteLines are for seing indexes and number needed for the task.

            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine("Index of smallest integer of array: " + indexOfMin);
            Console.WriteLine("Index of largest integer of array: " + indexOfMax);
            Console.WriteLine("Smallest and most leftmost number of array: " + arrayAsList[indexOfMin]);
            Console.WriteLine("Largest and most rightmost number of array: " + arrayAsList[indexOfMax]);
            Console.WriteLine("the answer is: " + sum);
        }
    }
}
