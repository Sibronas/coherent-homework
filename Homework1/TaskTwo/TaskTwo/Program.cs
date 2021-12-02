using System;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskTwo();
        }

        private static void TaskTwo()
        {
            var input = Console.ReadLine();

            // input = "999215810"; // TODO: remove

            var start = 10;

            var sum = 0;

            foreach (var number in input)
            {
                var x = int.Parse(number.ToString());

                sum += x * start--;
            }

            var temp = sum % 11;

            var checkDigit = 11 - temp;

            var result = checkDigit == 10 ? input + "X" : input + checkDigit;

            Console.WriteLine(result);
        }
    }
}
