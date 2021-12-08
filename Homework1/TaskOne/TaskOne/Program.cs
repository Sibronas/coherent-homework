using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskOne();
        }

        private static void TaskOne()
        {
            
            var numberOne = int.Parse(Console.ReadLine());
            var numberTwo = int.Parse(Console.ReadLine());
            
            var range = Enumerable.Range(numberOne, numberTwo - numberOne + 1);

            var results = new List<int>();

            foreach (var number in range)

            {
                var numberInTernary = ToTernary(number);

                if (numberInTernary.Count(x => x == '2') == 2)
                {
                    results.Add(number);
                }
            }

            Console.WriteLine(string.Join(", ", results));
        }

        private static string ToTernary(int number)
        {
            if (number is 0)
            {
                return "0";
            } 

            var tempList = new List<int>();

            while (number != 0)
            {
                var temp = number % 3;

                number /= 3;

                tempList.Add(temp);
            }

            tempList.Reverse();

            return string.Join(string.Empty, tempList);
        }
    }
}
